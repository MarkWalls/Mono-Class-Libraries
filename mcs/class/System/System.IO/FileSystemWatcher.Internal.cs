// 
// System.IO.FileSystemWatcher.cs
//
// Authors:
// 	Tim Coleman (tim@timcoleman.com)
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// Copyright (C) Tim Coleman, 2002 
// (c) 2003 Ximian, Inc. (http://www.ximian.com)
// Copyright (C) 2004, 2006 Novell, Inc (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.IO
{
	public partial class FileSystemWatcher
	{
		
		/* 0 -> not supported	*/
		/* 1 -> windows		*/
		/* 2 -> FAM		*/
		/* 3 -> Kevent		*/
		/* 4 -> gamin		*/
		/* 5 -> inotify		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern int InternalSupportsFSW ();

	}
}