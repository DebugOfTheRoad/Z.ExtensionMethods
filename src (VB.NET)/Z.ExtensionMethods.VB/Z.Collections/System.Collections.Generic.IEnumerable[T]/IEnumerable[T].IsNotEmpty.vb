
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Linq

Public Module Extensions_32

	''' <summary>
	'''     An IEnumerable&lt;T&gt; extension method that queries if a not is empty.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The collection to act on.</param>
	''' <returns>true if a not is t>, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNotEmpty(Of T)(this As IEnumerable(Of T)) As Boolean
		Return this.Any()
	End Function
End Module


