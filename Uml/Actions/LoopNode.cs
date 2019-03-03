﻿// -------------------------------------------------------------------------------------------------
// <copyright file="LoopNode.cs" company="RHEA System S.A.">
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

namespace Uml.Actions
{
    using Uml.Assembler;
    using System.Collections.Generic;
    using Uml.Activities;

    /// <summary>
    /// A <see cref="LoopNode"/> is a <see cref="StructuredActivityNode"/> that represents an iterative loop with setup, test, and body sections.
    /// </summary>
    public interface LoopNode : StructuredActivityNode
    {
        /// <summary>
        /// The OutputPins on Actions within the bodyPart, the values of which are moved to the loopVariable OutputPins after the completion of each execution of the bodyPart, before the next iteration of the loop begins or before the loop exits.
        /// </summary>
        OutputPin BodyOutput { get; set; }

        /// <summary>
        /// The set of <see cref="ExecutableNode"/>s that perform the repetitive computations of the loop. The bodyPart is executed as long as the test section produces a true value.
        /// </summary>
        List<ExecutableNode> BodyPart { get; set; }

        /// <summary>
        /// An <see cref="OutputPin"/> on an <see cref="Action"/> in the test section whose Boolean value determines whether to continue executing the loop bodyPart.
        /// </summary>
        OutputPin Decider { get; set; }

        /// <summary>
        /// If true, the test is performed before the first execution of the bodyPart. If false, the bodyPart is executed once before the test is performed.
        /// </summary>
        bool IsTestedFirst { get; set; }

        /// <summary>
        /// A list of <see cref="OutputPin"/>s that hold the values of the loop variables during an execution of the loop. When the test fails, the values are moved to the result <see cref="OutputPin"/>s of the loop.
        /// </summary>
        OwnerList<OutputPin> LoopVariable { get; set }

        /// <summary>
        /// A list of <see cref="OutputPin"/>s that receive the loopVariable values after the last iteration of the loop and constitute the output of the <see cref="LoopNode"/>.
        /// </summary>
        OwnerList<OutputPin> Result { get; set }

        /// <summary>
        /// The set of <see cref="ExecutableNode"/>s executed before the first iteration of the loop, in order to initialize values or perform other setup computations.
        /// </summary>
        List<ExecutableNode> SetupPart { get; set; }

        /// <summary>
        /// The set of <see cref="ExecutableNode"/>s executed in order to provide the test result for the loop.
        /// </summary>
        List<ExecutableNode> Test { get; set; }
    }
}