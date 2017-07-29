using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ViewDataTest_V1.Common;
using ViewDataTest_V1.Entities.Common;
using ViewDataTest_V1.ViewDatas.Interfaces;

namespace ViewDataTest_V1.ViewDatas.Core
{
    public class ViewDataBuilder : IViewDataBuilder
    {
        public IViewData Build<E>(IViewData viewData, E result)
        {
            var propertiesAttributes = CustomAttributeExtractorExtensions.GetPropertyAttributesFromType<PropertieAttribute>(typeof(E));

            foreach (var attr in propertiesAttributes)
            {
                var newProp = _buildProp(attr, result);
                viewData.Properties.Add(newProp);
            }

            return viewData;
        }

        private Property _buildProp<E>(CustomAttributeExtractorExtensions.PropertyAttributeContainer<PropertieAttribute> attr, E result)
        {
            Property newProp = new Property();
            newProp.Name = attr.Attribute.Name;
            newProp.Type = attr.Attribute.Type.ToString();

            switch (attr.Attribute.Type)
            {
                case PropertyEnum.String:
                    newProp.Value_String = (string)attr.Property.GetValue(result, null);
                    break;

                default:
                    break;
            }

            return newProp;
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