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
// Generated by IDLImporter from file nsIDOMXMLDocument.idl
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
	
	
	/// <summary>nsIDOMXMLDocument </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8816d003-e7c8-4065-8827-829b8d07b6e0")]
	public interface nsIDOMXMLDocument : nsIDOMDocument
	{
		
		/// <summary>
        /// The nsIDOMNode interface is the primary datatype for the entire
        /// Document Object Model.
        /// It represents a single node in the document tree.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Core/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		/// <summary>Member GetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member SetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		/// <summary>Member GetParentNodeAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNodeAttribute();
		
		/// <summary>Member GetChildNodesAttribute </summary>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodesAttribute();
		
		/// <summary>Member GetFirstChildAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChildAttribute();
		
		/// <summary>Member GetLastChildAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChildAttribute();
		
		/// <summary>Member GetPreviousSiblingAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSiblingAttribute();
		
		/// <summary>Member GetNextSiblingAttribute </summary>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSiblingAttribute();
		
		/// <summary>Member GetAttributesAttribute </summary>
		/// <returns>A nsIDOMNamedNodeMap</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocumentAttribute();
		
		/// <summary>Member InsertBefore </summary>
		/// <param name='newChild'> </param>
		/// <param name='refChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode refChild);
		
		/// <summary>Member ReplaceChild </summary>
		/// <param name='newChild'> </param>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		/// <summary>Member RemoveChild </summary>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		/// <summary>Member AppendChild </summary>
		/// <param name='newChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild);
		
		/// <summary>Member HasChildNodes </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>Member CloneNode </summary>
		/// <param name='deep'> </param>
		/// <returns>A nsIDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode([MarshalAs(UnmanagedType.Bool)] bool deep);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// The nsIDOMDocument interface represents the entire HTML or XML document.
        /// Conceptually, it is the root of the document tree, and provides the
        /// primary access to the document's data.
        /// Since elements, text nodes, comments, processing instructions, etc.
        /// cannot exist outside the context of a Document, the nsIDOMDocument
        /// interface also contains the factory methods needed to create these
        /// objects.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Core/
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentType GetDoctypeAttribute();
		
		/// <summary>Member GetImplementationAttribute </summary>
		/// <returns>A nsIDOMDOMImplementation</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDOMImplementation GetImplementationAttribute();
		
		/// <summary>Member GetDocumentElementAttribute </summary>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetDocumentElementAttribute();
		
		/// <summary>Member CreateElement </summary>
		/// <param name='tagName'> </param>
		/// <returns>A nsIDOMElement</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAString tagName);
		
		/// <summary>Member CreateDocumentFragment </summary>
		/// <returns>A nsIDOMDocumentFragment</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentFragment CreateDocumentFragment();
		
		/// <summary>Member CreateTextNode </summary>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMText</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMText CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateComment </summary>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMComment</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMComment CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateCDATASection </summary>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMCDATASection</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCDATASection CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateProcessingInstruction </summary>
		/// <param name='target'> </param>
		/// <param name='data'> </param>
		/// <returns>A nsIDOMProcessingInstruction</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMProcessingInstruction CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target, [MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member CreateAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member CreateEntityReference </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMEntityReference</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEntityReference CreateEntityReference([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member GetElementsByTagName </summary>
		/// <param name='tagname'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString tagname);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ImportNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode importedNode, [MarshalAs(UnmanagedType.Bool)] bool deep);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAString elementId);
		
		/// <summary>
        /// Whether to load synchronously or asynchronously.
        /// The default is async==true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAsyncAttribute();
		
		/// <summary>
        /// Whether to load synchronously or asynchronously.
        /// The default is async==true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAsyncAttribute([MarshalAs(UnmanagedType.Bool)] bool aAsync);
		
		/// <summary>
        /// Load an XML document.
        ///
        /// @param  url URL to an XML document.
        /// @return     True if load successfull.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Load([MarshalAs(UnmanagedType.LPStruct)] nsAString url);
		
		/// <summary>
        /// Evaluate FIXptr expression. FIXptr is a W3C NOTE, see
        ///
        /// http://lists.w3.org/Archives/Public/www-xml-linking-comments/2001AprJun/att-0074/01-NOTE-FIXptr-20010425.htm
        ///
        /// @param  expression FIXptr string.
        /// @return            The range object that results from evaluation
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange EvaluateFIXptr([MarshalAs(UnmanagedType.LPStruct)] nsAString expression);
		
		/// <summary>
        /// Evaluate XPointer expression.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPointerResult EvaluateXPointer([MarshalAs(UnmanagedType.LPStruct)] nsAString expression);
	}
}
