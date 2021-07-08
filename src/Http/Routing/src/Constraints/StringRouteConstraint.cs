// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
    /// <summary>
    /// Constrains a route parameter to contain only a specified string.
    /// </summary>
    public class StringRouteConstraint : IRouteConstraint, ILiteralConstraint
    {
        private string _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringRouteConstraint"/> class.
        /// </summary>
        /// <param name="value">The constraint value to match.</param>
        public StringRouteConstraint(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _value = value;
        }

        /// <inheritdoc />
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (routeKey == null)
            {
                throw new ArgumentNullException(nameof(routeKey));
            }

            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.TryGetValue(routeKey, out var routeValue)
                && routeValue != null)
            {
                var parameterValueString = Convert.ToString(routeValue, CultureInfo.InvariantCulture)!;
                return CheckConstraintCore(parameterValueString);
            }

            return false;
        }

        private bool CheckConstraintCore(string parameterValueString)
        {
            return parameterValueString.Equals(_value, StringComparison.OrdinalIgnoreCase);
        }

        bool ILiteralConstraint.MatchLiteral(string parameterName, string literal)
        {
            return CheckConstraintCore(literal);
        }
    }
}
