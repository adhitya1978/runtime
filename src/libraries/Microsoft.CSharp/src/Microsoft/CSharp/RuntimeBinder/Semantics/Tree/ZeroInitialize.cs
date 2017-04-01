// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal sealed class ExprZeroInit : Expr
    {
        public Expr OptionalArgument { get; set; }

        public Expr OptionalConstructorCall { get; set; }

        public bool IsConstructor { get; set; }

        public override ExpressionKind Kind => ExpressionKind.EK_ZEROINIT;
    }
}
