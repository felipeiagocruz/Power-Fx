﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.PowerFx.Core.Types.Enums;

namespace Microsoft.PowerFx.Core.Texl.Intellisense
{
    internal static class IntellisenseProvider
    {
        internal static readonly ISuggestionHandler[] SuggestionHandlers =
        {
            new Intellisense.CommentNodeSuggestionHandler(),
            new Intellisense.NullNodeSuggestionHandler(),
            new Intellisense.StrInterpSuggestionHandler(),
            new Intellisense.FunctionRecordNameSuggestionHandler(),
            new Intellisense.ErrorNodeSuggestionHandler(),
            new Intellisense.BlankNodeSuggestionHandler(),
            new Intellisense.DottedNameNodeSuggestionHandler(),
            new Intellisense.FirstNameNodeSuggestionHandler(),
            new Intellisense.CallNodeSuggestionHandler(),
            new Intellisense.BinaryOpNodeSuggestionHandler(),
            new Intellisense.UnaryOpNodeSuggestionHandler(),
            new Intellisense.BoolLitNodeSuggestionHandler(),
            new Intellisense.StrNumLitNodeSuggestionHandler(),
            new Intellisense.RecordNodeSuggestionHandler(),
        };

        internal static IIntellisense GetIntellisense(IEnumStore enumStore)
        {
            return new Intellisense(enumStore, SuggestionHandlers);
        }
    }
}
