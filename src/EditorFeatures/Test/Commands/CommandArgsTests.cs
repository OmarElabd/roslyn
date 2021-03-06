// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using Microsoft.CodeAnalysis.Editor.Commands;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.EditorUtilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Editor.UnitTests.Commands
{
    public class CommandArgsTests
    {
        [Fact]
        public void CreateBackspaceCommandArgsWithNullTextView()
        {
            var buffer = EditorFactory.CreateBuffer(TestExportProvider.ExportProviderWithCSharpAndVisualBasic, "class C { }");

            Assert.Throws<ArgumentNullException>(() =>
                new BackspaceKeyCommandArgs(null, buffer));
        }

        [Fact]
        public void CreateBackspaceCommandArgsWithNullSubjectBuffer()
        {
            var view = EditorFactory.CreateView(TestExportProvider.ExportProviderWithCSharpAndVisualBasic, "class C { }");

            Assert.Throws<ArgumentNullException>(() =>
                new BackspaceKeyCommandArgs(view, null));
        }
#if false
        [Fact]
        public void TestTextViewProperty()
        {
            var view = new StandardBufferView(EditorFactory.CreateView(TestExportProvider.ExportProvider, "class C { }"));

            var args = new BackspaceKeyCommandArgs(view, view.TextBuffer);
            Assert.Equal(view, args.TextView);
        }

        [Fact]
        public void TestSubjectProperty()
        {
            var view = new StandardBufferView(EditorFactory.CreateView(TestExportProvider.ExportProvider, "class C { }"));

            var args = new BackspaceKeyCommandArgs(view, view.TextBuffer);
            Assert.Equal(view.TextBuffer, args.SubjectBuffer);
        }

        [Fact]
        public void TestInvokeQuickInfoCommandArgs()
        {
            var view = new StandardBufferView(EditorFactory.CreateView(TestExportProvider.ExportProvider, "class C { }"));
            new InvokeQuickInfoCommandArgs(view, view.TextBuffer);
        }
#endif
    }
}
