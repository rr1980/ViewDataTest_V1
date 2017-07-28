using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ViewDataTest_V1.Entities.Common;
using ViewDataTest_V1.ViewDatas.Interfaces;

namespace ViewDataTest_V1.ViewDatas.Core
{
    public class ViewDataBuilder : IViewDataBuilder
    {
        public IViewData Build<E>(IViewData viewData, E result)
        {
            var propertiesAtributes = CustomAttributeExtractorExtensions.GetPropertyAttributesFromType<PropertieAttribute>(typeof(E));

            foreach (var prop in propertiesAtributes)
            {
                viewData.Properties.Add(new Property(prop.Attribute.Type.ToString(), prop.Attribute.Name));
            }

            return viewData;
        }
    }

    public static class CustomAttributeExtractorExtensions
    {
        public static List<PropertyAttributeContainer<TAttributeType>> GetPropertyAttributesFromType<TAttributeType>(this Type typeToReflect)
            where TAttributeType : Attribute
        {
            var list = new List<PropertyAttributeContainer<TAttributeType>>();

            var properties = typeToReflect.GetProperties();

            foreach (var propertyInfo in properties)
            {
                var attributes = propertyInfo.GetCustomAttributes<TAttributeType>(true).ToList();
                if (!attributes.Any()) continue;

                list.AddRange(attributes.Select(attr => new PropertyAttributeContainer<TAttributeType>(attr, propertyInfo)));
            }

            var interfaces = typeToReflect.GetInterfaces();

            foreach (var @interface in interfaces)
            {
                list.AddRange(@interface.GetPropertyAttributesFromType<TAttributeType>());
            }

            return list;
        }

        public class PropertyAttributeContainer<TAttributeType>
        {
            internal PropertyAttributeContainer(TAttributeType attribute, PropertyInfo property)
            {
                Property = property;
                Attribute = attribute;
            }

            public PropertyInfo Property { get; private set; }

            public TAttributeType Attribute { get; private set; }
        }
    }
}