// 
// RtfWriterTests.cs
//  
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
// 
// Copyright (c) 2012 Xamarin Inc. (http://xamarin.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using Mono.TextEditor.Utils;
using NUnit.Framework;
using Mono.TextEditor.Highlighting;

namespace Mono.TextEditor.Tests
{
	[TestFixture()]
	public class RtfWriterTests : TextEditorTestBase
	{
		[Test()]
		public void TestSimpleCSharpRtf ()
		{
			var data = Create ("class Foo {}");
			var style = SyntaxModeService.GetColorStyle (null, "TangoLight");
			ISyntaxMode mode = SyntaxModeService.GetSyntaxMode (data.Document, "text/x-csharp");
			string generatedRtf = RtfWriter.GenerateRtf (data.Document, mode, style, data.Options);
			Assert.AreEqual (
			@"{\rtf1\ansi\deff0\adeflang1025{\fonttbl{\f0\fnil\fprq1\fcharset128 Mono;}}{\colortbl ;\red92\green53\blue102;\red0\green0\blue0;}\viewkind4\uc1\pard\f0\fs20\cf1\b\cf1 class\b0\cf2  Foo \{\}\par
}", generatedRtf);
		}
	}
}

