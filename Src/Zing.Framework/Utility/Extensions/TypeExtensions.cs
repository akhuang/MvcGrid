using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.Utility.Extensions
{
    public static class TypeExtensions
    {
        internal static string GetName(this Type type)
        {
            return type.FullName.Replace(type.Namespace + ".", "");
        }

        /// <summary>
        /// Executes the provided delegate for each item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="action">The action to be applied.</param>
        public static void Each<T>(this IEnumerable<T> instance, Action<T> action)
        {
            foreach (T item in instance)
            {
                action(item);
            }
        }

    }
}
