// 
// DotNetExecutionCommand.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
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
using System.Collections.Generic;
using MonoDevelop.Core.Assemblies;

namespace MonoDevelop.Core.Execution
{
	public class DotNetExecutionCommand: ProcessExecutionCommand
	{
		TargetRuntime targetRuntime;
		
		public DotNetExecutionCommand()
		{
		}
		
		public DotNetExecutionCommand (string command)
			: base (command)
		{
		}
		
		public DotNetExecutionCommand (string command, string arguments)
			: base (command, arguments)
		{
		}
		
		public DotNetExecutionCommand (string command, string arguments, string workingDirectory)
			: base (command, arguments, workingDirectory)
		{
		}
		
		public DotNetExecutionCommand (string command, string arguments, string workingDirectory, IDictionary<string, string> environmentVariables)
			: base (command, arguments, workingDirectory, environmentVariables)
		{
		}
		
		public TargetRuntime TargetRuntime {
			get {
				if (targetRuntime == null)
					targetRuntime = Runtime.SystemAssemblyService.DefaultRuntime;
				return targetRuntime;
			}
			set {
				targetRuntime = value;
			}
		}
		
		public bool DebugMode { get; set; }
		
		public string RuntimeArguments { get; set; }
		
		public IList<string> UserAssemblyPaths { get; set; }

		public bool PauseConsoleOutput { get; set; }

		public bool ExternalConsole { get; set; }
	}
}
