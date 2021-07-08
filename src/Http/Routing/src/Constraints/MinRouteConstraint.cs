// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
    /// <summary>
    /// Constrains a route parameter to be a long with a minimum value.
    /// </summary>
    public class MinRouteConstraint : IRouteConstraint, ILiteralConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinRouteConstraint" /> class.
        /// </summary>
        /// <param name="min">The minimum value allowed for the route parameter.</param>
        public MinRouteConstraint(long min)
        {
            Min = min;
        }

        /// <summary>
        /// Gets the minimum allowed value of the route parameter.
        /// </summary>
        public long Min { get; }

        /// <inheritdoc />
        public bool Match(
            HttpContext? httpContext,
            IRouter? route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (routeKey == null)
            {
                throw new ArgumentNullException(nameof(routeKey));
            }

            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.TryGetValue(routeKey, out var value) && value != null)
            {
                var valueString = Convert.ToString(value, CultureInfo.InvariantCulture);
                return CheckConstraintCore(valueString);
            }

            return false;
        }

        private bool CheckConstraintCore(string? valueString)
        {
            if (long.TryParse(valueString, NumberStyles.Integer, CultureInfo.InvariantCulture, out var longValue))
            {
                return longValue >= Min;
            }
            return false;
        }

        bool ILiteralConstraint.MatchLiteral(string parameterName, string literal)
        {
            return CheckConstraintCore(literal);
        }
    }
}
