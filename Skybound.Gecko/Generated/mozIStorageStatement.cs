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
// Generated by IDLImporter from file mozIStorageStatement.idl
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
    /// A SQL statement that can be used for both synchronous and asynchronous
    /// purposes.
    /// </summary>
	[ComImport()]
	[Guid("57ec7be1-36cf-4510-b938-7d1c9ee8cec5")]
	public interface mozIStorageStatement : mozIStorageBaseStatement
	{
		
		/// <summary>
        /// Finalizes a statement so you can successfully close a database connection.
        /// Once a statement has been finalized it can no longer be used for any
        /// purpose.
        ///
        /// Statements are implicitly finalized when their reference counts hits zero.
        /// If you are a native (C++) caller this is accomplished by setting all of
        /// your nsCOMPtr instances to be NULL.  If you are operating from JavaScript
        /// code then you cannot rely on this behavior because of the involvement of
        /// garbage collection.
        ///
        /// When finalizing an asynchronous statement you do not need to worry about
        /// whether the statement has actually been executed by the asynchronous
        /// thread; you just need to call finalize after your last call to executeAsync
        /// involving the statement.  However, you do need to use asyncClose instead of
        /// close on the connection if any statements have been used asynchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Finalize();
		
		/// <summary>
        /// Bind the given value at the given numeric index.
        ///
        /// @param aParamIndex
        /// 0-based index, 0 corresponding to the first numbered argument or
        /// "?1".
        /// @param aValue
        /// Argument value.
        /// @param aValueSize
        /// Length of aValue in bytes.
        /// @{
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindUTF8StringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindStringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindDoubleParameter(uint aParamIndex, double aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindInt32Parameter(uint aParamIndex, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindInt64Parameter(uint aParamIndex, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindNullParameter(uint aParamIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindBlobParameter(uint aParamIndex, System.IntPtr aValue, uint aValueSize);
		
		/// <summary>
        /// Binds the array of parameters to the statement.  When executeAsync is
        /// called, all the parameters in aParameters are bound and then executed.
        ///
        /// @param aParameters
        /// The array of parameters to bind to the statement upon execution.
        ///
        /// @note This is only works on statements being used asynchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BindParameters(mozIStorageBindingParamsArray aParameters);
		
		/// <summary>
        /// Creates a new mozIStorageBindingParamsArray that can be used to bind
        /// multiple sets of data to a statement with bindParameters.
        ///
        /// @return a mozIStorageBindingParamsArray that multiple sets of parameters
        /// can be bound to.
        ///
        /// @note This is only useful for statements being used asynchronously.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new mozIStorageBindingParamsArray NewBindingParamsArray();
		
		/// <summary>
        /// Execute a query asynchronously using any currently bound parameters.  This
        /// statement can be reused immediately, and reset does not need to be called.
        ///
        /// @note If you have any custom defined functions, they must be re-entrant
        /// since they can be called on multiple threads.
        ///
        /// @param aCallback [optional]
        /// The callback object that will be notified of progress, errors, and
        /// completion.
        /// @return an object that can be used to cancel the statements execution.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new mozIStoragePendingStatement ExecuteAsync(mozIStorageStatementCallback aCallback);
		
		/// <summary>
        /// Find out whether the statement is usable (has not been finalized).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetStateAttribute();
		
		/// <summary>
        /// Escape a string for SQL LIKE search.
        ///
        /// @note Consumers will have to use same escape char when doing statements
        /// such as:   ...LIKE '?1' ESCAPE '/'...
        ///
        /// @param aValue
        /// The string to escape for SQL LIKE.
        /// @param aEscapeChar
        /// The escape character.
        /// @return an AString of an escaped version of aValue
        /// (%, _ and the escape char are escaped with the escape char)
        /// For example, we will convert "foo/bar_baz%20cheese"
        /// into "foo//bar/_baz/%20cheese" (if the escape char is '/').
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void EscapeStringForLIKE([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue, char aEscapeChar, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Create a clone of this statement, by initializing a new statement
        /// with the same connection and same SQL statement as this one.  It
        /// does not preserve statement state; that is, if a statement is
        /// being executed when it is cloned, the new statement will not be
        /// executing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageStatement Clone();
		
		/// <summary>
        /// Number of parameters
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetParameterCountAttribute();
		
		/// <summary>
        /// Name of nth parameter, if given
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetParameterName(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		/// <summary>
        /// Returns the index of the named parameter.
        ///
        /// @param aName
        /// The name of the parameter you want the index for.  This does not
        /// include the leading ':'.
        /// @return the index of the named parameter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetParameterIndex([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Number of columns returned
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetColumnCountAttribute();
		
		/// <summary>
        /// Name of nth column
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetColumnName(uint aColumnIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		/// <summary>
        /// Obtains the index of the column with the specified name.
        ///
        /// @param aName
        /// The name of the column.
        /// @return The index of the column with the specified name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetColumnIndex([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Obtains the declared column type of a prepared statement.
        ///
        /// @param aParamIndex
        /// The zero-based index of the column who's declared type we are
        /// interested in.
        /// @return the declared index type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetColumnDecltype(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		/// <summary>
        /// Reset parameters/statement execution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reset();
		
		/// <summary>
        /// Execute the query, ignoring any results.  This is accomplished by
        /// calling executeStep() once, and then calling reset().
        ///
        /// Error and last insert info, etc. are available from
        /// the mozStorageConnection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Execute();
		
		/// <summary>
        /// Execute a query, using any currently-bound parameters.  Reset
        /// must be called on the statement after the last call of
        /// executeStep.
        ///
        /// @return a boolean indicating whether there are more rows or not;
        /// row data may be accessed using mozIStorageValueArray methods on
        /// the statement.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ExecuteStep();
		
		/// <summary>
        /// The number of entries in the array (each corresponding to a column in the
        /// database row)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumEntriesAttribute();
		
		/// <summary>
        /// Indicate the data type of the current result row for the the given column.
        /// SQLite will perform type conversion if you ask for a value as a different
        /// type than it is stored as.
        ///
        /// @param aIndex
        /// 0-based column index.
        /// @return The type of the value at the given column index; one of
        /// VALUE_TYPE_NULL, VALUE_TYPE_INTEGER, VALUE_TYPE_FLOAT,
        /// VALUE_TYPE_TEXT, VALUE_TYPE_BLOB.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTypeOfIndex(uint aIndex);
		
		/// <summary>
        /// Retrieve the contents of a column from the current result row as an
        /// integer.
        ///
        /// @param aIndex
        /// 0-based colummn index.
        /// @return Column value interpreted as an integer per type conversion rules.
        /// @{
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt32(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt64(uint aIndex);
		
		/// <summary>
        /// Retrieve the contents of a column from the current result row as a
        /// floating point double.
        ///
        /// @param aIndex
        /// 0-based colummn index.
        /// @return Column value interpreted as a double per type conversion rules.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDouble(uint aIndex);
		
		/// <summary>
        /// Retrieve the contents of a column from the current result row as a
        /// string.
        ///
        /// @param aIndex
        /// 0-based colummn index.
        /// @return The value for the result column interpreted as a string.  If the
        /// stored value was NULL, you will get an empty string with IsVoid set
        /// to distinguish it from an explicitly set empty string.
        /// @{
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetString(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Retrieve the contents of a column from the current result row as a
        /// blob.
        ///
        /// @param aIndex
        /// 0-based colummn index.
        /// @param[out] aDataSize
        /// The number of bytes in the blob.
        /// @param[out] aData
        /// The contents of the BLOB.  This will be NULL if aDataSize == 0.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBlob(uint aIndex, out uint aDataSize, out System.IntPtr aData);
		
		/// <summary>
        /// Check whether the given column in the current result row is NULL.
        ///
        /// @param aIndex
        /// 0-based colummn index.
        /// @return true if the value for the result column is null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsNull(uint aIndex);
		
		/// <summary>
        /// Returns a shared string pointer
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSharedUTF8String(uint aIndex, out uint aLength);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSharedString(uint aIndex, out uint aLength);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSharedBlob(uint aIndex, out uint aLength);
	}
}
