// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIJSON.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// Encode and decode JSON text.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a4d68b4e-0c0b-4c7c-b540-ef2f9834171f")]
	public interface nsIJSON
	{
		
		/// <summary>
        ///in JSObject value </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Encode([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        ///in JSObject value </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.Bool)] bool writeBOM);
		
		/// <summary>
        ///JSObject </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Decode([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		/// <summary>
        ///JSObject </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodeFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, int contentLength);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeFromJSVal(System.IntPtr value, System.IntPtr cx, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Make sure you GCroot the result of this function before using it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr DecodeToJSVal([MarshalAs(UnmanagedType.LPStruct)] nsAString str, System.IntPtr cx);
		
		/// <summary>
        ///JSObject </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LegacyDecode([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		/// <summary>
        ///JSObject </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LegacyDecodeFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, int contentLength);
		
		/// <summary>
        /// Make sure you GCroot the result of this function before using it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr LegacyDecodeToJSVal([MarshalAs(UnmanagedType.LPStruct)] nsAString str, System.IntPtr cx);
	}
}
