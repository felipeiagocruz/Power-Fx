﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.PowerFx.Core.Public.Types;
using Microsoft.PowerFx.Core.Types;
using Microsoft.PowerFx.Interpreter;
using Xunit;

namespace Microsoft.PowerFx.Tests
{
    public class FunctionCompilationTests
    {
        [Theory]
        [InlineData("Switch(A, 2, \"two\", \"other\")")]
        [InlineData("IfError(Text(A), Switch(FirstError.Kind, ErrorKind.Div0, \"Division by zero\", ErrorKind.Numeric, \"Numeric error\", \"Other error\"))")]
        public void TestSwitchFunctionCompilation(string expression)
        {
            var engine = new RecalcEngine();
            engine.UpdateVariable("A", 15);
            var check = engine.Check(expression);
            Assert.True(check.IsSuccess);
            Assert.Null(check.Errors);
            Assert.Equal(FormulaType.String, check.ReturnType);
        }
    }
}