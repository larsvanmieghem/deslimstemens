﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Slimsemens.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property achtergrond() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("achtergrond", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property dsmlogo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("dsmlogo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property kat() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("kat", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property platypus() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("platypus", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ---Naam---
        '''Jan1
        '''Platypus1
        '''Miauw1
        '''---Ronde1---
        '''Antw1
        '''Antw2
        '''Antw3
        '''Antw4
        '''Antw5
        '''Antw6
        '''Antw7
        '''Antw8
        '''Antw9
        '''Antw10
        '''Antw11
        '''Antw12
        '''Antw13
        '''Antw14
        '''Antw15
        '''---Ronde2links---
        '''Antw1
        '''ANtw2
        '''ANtw3
        '''ANtw4
        '''---Ronde2centraal---
        '''ANtw1
        '''ANtw2
        '''ANtw3
        '''ANtw4
        '''---Ronde2rechts
        '''ANtw1
        '''ANtw2
        '''ANtw3
        '''ANtw4
        '''---Ronde3puzzel1---
        '''Antw1
        '''Antw2
        '''Anwt3
        '''---Ronde3puzzel1tips---
        '''Vraag1tip1
        '''Vraag1tip2
        '''Vraag1tip3
        '''Vraag2tip1
        '''Vraag2tip2
        '''Vraag2tip3
        '''Vraag3tip1
        '''Vraag3tip2
        '''Vraag3tip3
        '''---Ronde3puzzel2---
        '''ANtw1
        '''ANtw2 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property spelbestandje() As String
            Get
                Return ResourceManager.GetString("spelbestandje", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
