/*
All rights reserved. This program and the accompanying materials
are made available under the terms of the Eclipse Public License v1.0
and Eclipse Distribution License v1.0 which accompany this distribution. 

The Eclipse Public License is available at 
   http://www.eclipse.org/legal/epl-v10.html
and the Eclipse Distribution License is available at 
   http://www.eclipse.org/org/documents/edl-v10.php.
*/

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("M2Mqtt.Net35.WebSockets")]
[assembly: AssemblyDescription("MQTT WebSockets Client Library for M2M communication on Net 3.5")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Cityzenith")]
[assembly: AssemblyProduct("M2Mqtt")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("4.3.2.1")]
// to avoid compilation error (AssemblyFileVersionAttribute doesn't exist) under .Net CF 3.5
#if !WindowsCE
[assembly: AssemblyFileVersion("4.3.2.1")]
#endif