﻿// -------------------------------------------------------------------------------------------------
// <copyright file="StringExpression.cs" company="RHEA System S.A.">
//   Copyright (c) 2018-2019 RHEA System S.A.
//
//   This file is part of uml-sharp
//
//   uml-sharp is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   uml-sharp is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with uml-sharp. If not, see<http://www.gnu.org/licenses/>.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Uml.Values
{
    using Uml.Assembler;
    using Uml.CommonStructure;

    /// <summary>
    /// A StringExpression is an Expression that specifies a String value that is derived by concatenating a sequence of operands with String values or a sequence of subExpressions, some of which might be template parameters.
    /// </summary>
    public interface StringExpression : TemplateableElement, Expression
    {
        /// <summary>
        /// The <see cref="StringExpression"/> of which this <see cref="StringExpression"/> is a subExpression.
        /// </summary>
        StringExpression OwningExpression { get; set; }

        /// <summary>
        /// The <see cref="StringExpression"/>s that constitute this <see cref="StringExpression"/>.
        /// </summary>
        OwnerList<StringExpression> SubExpression { get; set; }
    }
}