; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [258 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 74
	i64 30579257353033782, ; 1: Syncfusion.Buttons.XForms => 0x6ca3ac2c05d836 => 29
	i64 120698629574877762, ; 2: Mono.Android => 0x1accec39cafe242 => 25
	i64 210515253464952879, ; 3: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 64
	i64 232391251801502327, ; 4: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 96
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 97
	i64 501828368175033675, ; 6: XStoreApp => 0x6f6da3df7496d4b => 113
	i64 634308326490598313, ; 7: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 83
	i64 702024105029695270, ; 8: System.Drawing.Common => 0x9be17343c0e7726 => 10
	i64 720058930071658100, ; 9: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 77
	i64 761608270782653079, ; 10: Syncfusion.SfBusyIndicator.XForms.Android => 0xa91c6afe5ffe297 => 34
	i64 872800313462103108, ; 11: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 73
	i64 940822596282819491, ; 12: System.Transactions => 0xd0e792aa81923a3 => 118
	i64 996343623809489702, ; 13: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 109
	i64 1000557547492888992, ; 14: Mono.Security.dll => 0xde2b1c9cba651a0 => 128
	i64 1120440138749646132, ; 15: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 111
	i64 1315114680217950157, ; 16: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 59
	i64 1425944114962822056, ; 17: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 16
	i64 1624659445732251991, ; 18: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 57
	i64 1628611045998245443, ; 19: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 85
	i64 1636321030536304333, ; 20: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 78
	i64 1637067789214310945, ; 21: AutoMapper.dll => 0x16b8087b115a6221 => 19
	i64 1731380447121279447, ; 22: Newtonsoft.Json => 0x18071957e9b889d7 => 27
	i64 1743969030606105336, ; 23: System.Memory.dll => 0x1833d297e88f2af8 => 127
	i64 1795316252682057001, ; 24: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 58
	i64 1836611346387731153, ; 25: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 96
	i64 1875917498431009007, ; 26: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 55
	i64 1981742497975770890, ; 27: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 84
	i64 2076847052340733488, ; 28: Syncfusion.Core.XForms => 0x1cd27163f7962630 => 31
	i64 2133195048986300728, ; 29: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 27
	i64 2136356949452311481, ; 30: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 89
	i64 2165725771938924357, ; 31: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 62
	i64 2262844636196693701, ; 32: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 73
	i64 2284400282711631002, ; 33: System.Web.Services => 0x1fb3d1f42fd4249a => 119
	i64 2287834202362508563, ; 34: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 12
	i64 2329709569556905518, ; 35: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 81
	i64 2469392061734276978, ; 36: Syncfusion.Core.XForms.Android.dll => 0x22450aff2ad74f72 => 30
	i64 2470498323731680442, ; 37: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 68
	i64 2479423007379663237, ; 38: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 101
	i64 2497223385847772520, ; 39: System.Runtime => 0x22a7eb7046413568 => 51
	i64 2547086958574651984, ; 40: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 54
	i64 2592350477072141967, ; 41: System.Xml.dll => 0x23f9e10627330e8f => 52
	i64 2624866290265602282, ; 42: mscorlib.dll => 0x246d65fbde2db8ea => 26
	i64 2689772414458801262, ; 43: Syncfusion.SfTabView.XForms.Android => 0x2553fdc28a762c6e => 44
	i64 2694427813909235223, ; 44: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 93
	i64 2960931600190307745, ; 45: Xamarin.Forms.Core => 0x2917579a49927da1 => 107
	i64 3017704767998173186, ; 46: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 111
	i64 3289520064315143713, ; 47: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 80
	i64 3303437397778967116, ; 48: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 56
	i64 3311221304742556517, ; 49: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 50
	i64 3313953730132644392, ; 50: Microsoft.Rest.ClientRuntime => 0x2dfd875c06a31228 => 24
	i64 3380777203843065839, ; 51: Autofac => 0x2eeaeef46bcde7ef => 17
	i64 3493805808809882663, ; 52: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 99
	i64 3522470458906976663, ; 53: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 98
	i64 3531994851595924923, ; 54: System.Numerics => 0x31042a9aade235bb => 49
	i64 3571415421602489686, ; 55: System.Runtime.dll => 0x319037675df7e556 => 51
	i64 3716579019761409177, ; 56: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 57: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 95
	i64 3756217500168923014, ; 58: Syncfusion.SfBusyIndicator.XForms => 0x3420c3ea44aca786 => 35
	i64 3772598417116884899, ; 59: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 74
	i64 3943415582112705276, ; 60: Syncfusion.Buttons.XForms.dll => 0x36b9d3942d916afc => 29
	i64 3966267475168208030, ; 61: System.Memory => 0x370b03412596249e => 127
	i64 4282138915307457788, ; 62: System.Reflection.Emit => 0x3b6d36a7ddc70cfc => 121
	i64 4525561845656915374, ; 63: System.ServiceModel.Internals => 0x3ece06856b710dae => 120
	i64 4533124835995628778, ; 64: System.Reflection.Emit.dll => 0x3ee8e505540534ea => 121
	i64 4622099135884840292, ; 65: XStore.Service => 0x4024feacd70e4d64 => 2
	i64 4636684751163556186, ; 66: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 103
	i64 4782108999019072045, ; 67: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 61
	i64 4794310189461587505, ; 68: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 54
	i64 4795410492532947900, ; 69: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 98
	i64 4906396365959678531, ; 70: Syncfusion.SfPicker.XForms => 0x4417057fe84b4a43 => 43
	i64 4941606650460547470, ; 71: Syncfusion.SfTabView.XForms.dll => 0x44941d111c68a98e => 45
	i64 5081566143765835342, ; 72: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 4
	i64 5099468265966638712, ; 73: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 4
	i64 5142919913060024034, ; 74: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 108
	i64 5203618020066742981, ; 75: Xamarin.Essentials => 0x4836f704f0e652c5 => 106
	i64 5205316157927637098, ; 76: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 87
	i64 5348796042099802469, ; 77: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 88
	i64 5376510917114486089, ; 78: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 101
	i64 5408338804355907810, ; 79: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 100
	i64 5446034149219586269, ; 80: System.Diagnostics.Debug => 0x4b94333452e150dd => 14
	i64 5451019430259338467, ; 81: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 67
	i64 5507995362134886206, ; 82: System.Core.dll => 0x4c705499688c873e => 46
	i64 5692067934154308417, ; 83: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 105
	i64 5757522595884336624, ; 84: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 65
	i64 5775268978821181986, ; 85: Syncfusion.SfBusyIndicator.Android => 0x5025e0899cf83222 => 33
	i64 5814345312393086621, ; 86: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 93
	i64 5848635860608528381, ; 87: Syncfusion.SfPicker.Android => 0x512a8753ec2eaffd => 41
	i64 5854740529318600522, ; 88: Autofac.Extensions.DependencyInjection => 0x5140377dde1e1f4a => 18
	i64 5896680224035167651, ; 89: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 82
	i64 6085203216496545422, ; 90: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 109
	i64 6086316965293125504, ; 91: FormsViewGroup.dll => 0x5476f10882baef80 => 20
	i64 6284145129771520194, ; 92: System.Reflection.Emit.ILGeneration => 0x5735c4b3610850c2 => 122
	i64 6319713645133255417, ; 93: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 83
	i64 6401687960814735282, ; 94: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 81
	i64 6504860066809920875, ; 95: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 62
	i64 6548213210057960872, ; 96: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 71
	i64 6591024623626361694, ; 97: System.Web.Services.dll => 0x5b7805f9751a1b5e => 119
	i64 6659513131007730089, ; 98: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 77
	i64 6702948511146257190, ; 99: Microsoft.Rest.ClientRuntime.dll => 0x5d05a8283a9b2b26 => 24
	i64 6705503799304721630, ; 100: XStore.Android => 0x5d0ebc2d9d9714de => 0
	i64 6876862101832370452, ; 101: System.Xml.Linq => 0x5f6f85a57d108914 => 53
	i64 6894844156784520562, ; 102: System.Numerics.Vectors => 0x5faf683aead1ad72 => 50
	i64 7026608356547306326, ; 103: Syncfusion.Core.XForms.dll => 0x618387125bcb2356 => 31
	i64 7036436454368433159, ; 104: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 79
	i64 7103753931438454322, ; 105: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 76
	i64 7270811800166795866, ; 106: System.Linq => 0x64e71ccf51a90a5a => 124
	i64 7338192458477945005, ; 107: System.Reflection => 0x65d67f295d0740ad => 5
	i64 7488575175965059935, ; 108: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 53
	i64 7635363394907363464, ; 109: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 107
	i64 7637365915383206639, ; 110: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 106
	i64 7654504624184590948, ; 111: System.Net.Http => 0x6a3a4366801b8264 => 15
	i64 7735176074855944702, ; 112: Microsoft.CSharp => 0x6b58dda848e391fe => 22
	i64 7767211987177345230, ; 113: Syncfusion.SfPicker.Android.dll => 0x6bcaae265edc90ce => 41
	i64 7820441508502274321, ; 114: System.Data => 0x6c87ca1e14ff8111 => 11
	i64 7836164640616011524, ; 115: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 57
	i64 8044118961405839122, ; 116: System.ComponentModel.Composition => 0x6fa2739369944712 => 117
	i64 8064050204834738623, ; 117: System.Collections.dll => 0x6fe942efa61731bf => 6
	i64 8083354569033831015, ; 118: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 80
	i64 8087206902342787202, ; 119: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 47
	i64 8103644804370223335, ; 120: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 114
	i64 8113615946733131500, ; 121: System.Reflection.Extensions => 0x70995ab73cf916ec => 8
	i64 8167236081217502503, ; 122: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 21
	i64 8185542183669246576, ; 123: System.Collections => 0x7198e33f4794aa70 => 6
	i64 8207404984268202078, ; 124: Syncfusion.SfNavigationDrawer.XForms.Android => 0x71e68f593713a05e => 39
	i64 8255351628315781696, ; 125: Syncfusion.SfNavigationDrawer.Android.dll => 0x7290e69135b46a40 => 38
	i64 8277886878735836546, ; 126: AutoMapper => 0x72e0f64211eaa582 => 19
	i64 8290740647658429042, ; 127: System.Runtime.Extensions => 0x730ea0b15c929a72 => 7
	i64 8398329775253868912, ; 128: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 66
	i64 8400357532724379117, ; 129: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 92
	i64 8517710342570482946, ; 130: Syncfusion.Buttons.XForms.Android => 0x7634fc6d84959d02 => 28
	i64 8601935802264776013, ; 131: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 100
	i64 8626175481042262068, ; 132: Java.Interop => 0x77b654e585b55834 => 21
	i64 8638972117149407195, ; 133: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 22
	i64 8639588376636138208, ; 134: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 91
	i64 8684531736582871431, ; 135: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 116
	i64 8725526185868997716, ; 136: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 47
	i64 8798228592445829085, ; 137: Syncfusion.SfNavigationDrawer.XForms.dll => 0x7a19964a316b2fdd => 40
	i64 9312692141327339315, ; 138: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 105
	i64 9324707631942237306, ; 139: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 58
	i64 9500060720727514569, ; 140: Syncfusion.SfNavigationDrawer.Android => 0x83d6fee45b9addc9 => 38
	i64 9639952648375824392, ; 141: Syncfusion.SfNavigationDrawer.XForms => 0x85c7fddbea06f008 => 40
	i64 9653670174411988578, ; 142: Syncfusion.SfPicker.XForms.Android => 0x85f8b9e0549c1e62 => 42
	i64 9659729154652888475, ; 143: System.Text.RegularExpressions => 0x860e407c9991dd9b => 123
	i64 9662334977499516867, ; 144: System.Numerics.dll => 0x8617827802b0cfc3 => 49
	i64 9677336505120030785, ; 145: Syncfusion.SfNavigationDrawer.XForms.Android.dll => 0x864cce4757998041 => 39
	i64 9678050649315576968, ; 146: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 68
	i64 9711637524876806384, ; 147: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 88
	i64 9760577170057344074, ; 148: XStore.ServiceClient => 0x87748938f00e344a => 3
	i64 9808709177481450983, ; 149: Mono.Android.dll => 0x881f890734e555e7 => 25
	i64 9825649861376906464, ; 150: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 65
	i64 9834056768316610435, ; 151: System.Transactions.dll => 0x8879968718899783 => 118
	i64 9998632235833408227, ; 152: Mono.Security => 0x8ac2470b209ebae3 => 128
	i64 10038780035334861115, ; 153: System.Net.Http.dll => 0x8b50e941206af13b => 15
	i64 10229024438826829339, ; 154: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 71
	i64 10360651442923773544, ; 155: System.Text.Encoding => 0x8fc86d98211c1e68 => 9
	i64 10364469296367737616, ; 156: System.Reflection.Emit.ILGeneration.dll => 0x8fd5fde967711b10 => 122
	i64 10376576884623852283, ; 157: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 99
	i64 10430153318873392755, ; 158: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 69
	i64 10714184849103829812, ; 159: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 7
	i64 10847732767863316357, ; 160: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 59
	i64 10922724071211577087, ; 161: Autofac.dll => 0x97954fabf42caeff => 17
	i64 10964653383833615866, ; 162: System.Diagnostics.Tracing => 0x982a4628ccaffdfa => 126
	i64 11023048688141570732, ; 163: System.Core => 0x98f9bc61168392ac => 46
	i64 11037814507248023548, ; 164: System.Xml => 0x992e31d0412bf7fc => 52
	i64 11162124722117608902, ; 165: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 104
	i64 11254994354147455071, ; 166: XStore.ServiceClient.dll => 0x9c31c5bbcbfc705f => 3
	i64 11340910727871153756, ; 167: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 70
	i64 11392833485892708388, ; 168: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 94
	i64 11448851062131558867, ; 169: XStore.Android.dll => 0x9ee27d61e4b489d3 => 0
	i64 11485890710487134646, ; 170: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 125
	i64 11529969570048099689, ; 171: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 104
	i64 11578238080964724296, ; 172: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 79
	i64 11580057168383206117, ; 173: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 55
	i64 11597940890313164233, ; 174: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11606334278361545453, ; 175: Syncfusion.SfMaskedEdit.XForms.Android => 0xa111fb887e2dfaed => 36
	i64 11619874950061906932, ; 176: Syncfusion.SfTabView.XForms => 0xa14216b3cce65bf4 => 45
	i64 11672361001936329215, ; 177: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 76
	i64 11758626982801240232, ; 178: Syncfusion.SfBusyIndicator.XForms.Android.dll => 0xa32f08f0e430f0a8 => 34
	i64 11975068137832856544, ; 179: XStoreApp.dll => 0xa62ffd0654a03be0 => 113
	i64 12123043025855404482, ; 180: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 8
	i64 12137774235383566651, ; 181: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 102
	i64 12271526709721397701, ; 182: Syncfusion.SfPicker.XForms.dll => 0xaa4d388670a979c5 => 43
	i64 12312508881223092658, ; 183: Syncfusion.SfMaskedEdit.XForms.Android.dll => 0xaaded197cf2509b2 => 36
	i64 12451044538927396471, ; 184: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 75
	i64 12466513435562512481, ; 185: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 86
	i64 12487638416075308985, ; 186: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 72
	i64 12538491095302438457, ; 187: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 63
	i64 12550732019250633519, ; 188: System.IO.Compression => 0xae2d28465e8e1b2f => 115
	i64 12700543734426720211, ; 189: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 64
	i64 12832250852553794196, ; 190: Syncfusion.SfBusyIndicator.XForms.dll => 0xb2155029872c2294 => 35
	i64 12963446364377008305, ; 191: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 10
	i64 13370592475155966277, ; 192: System.Runtime.Serialization => 0xb98de304062ea945 => 16
	i64 13391361154981494717, ; 193: Syncfusion.Buttons.XForms.Android.dll => 0xb9d7ac051da2ffbd => 28
	i64 13401370062847626945, ; 194: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 102
	i64 13404347523447273790, ; 195: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 66
	i64 13454009404024712428, ; 196: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 112
	i64 13491513212026656886, ; 197: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 60
	i64 13572454107664307259, ; 198: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 95
	i64 13622732128915678507, ; 199: Syncfusion.Core.XForms.Android => 0xbd0daab1e651e52b => 30
	i64 13647894001087880694, ; 200: System.Data.dll => 0xbd670f48cb071df6 => 11
	i64 13902543935539791585, ; 201: Syncfusion.SfMaskedEdit.XForms => 0xc0efc20cf01c46e1 => 37
	i64 13959074834287824816, ; 202: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 75
	i64 13967638549803255703, ; 203: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 108
	i64 13970307180132182141, ; 204: Syncfusion.Licensing => 0xc1e0805ccade287d => 32
	i64 14124974489674258913, ; 205: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 63
	i64 14125464355221830302, ; 206: System.Threading.dll => 0xc407bafdbc707a9e => 13
	i64 14172845254133543601, ; 207: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 89
	i64 14261073672896646636, ; 208: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 94
	i64 14327695147300244862, ; 209: System.Reflection.dll => 0xc6d632d338eb4d7e => 5
	i64 14486659737292545672, ; 210: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 82
	i64 14538127318538747197, ; 211: Syncfusion.Licensing.dll => 0xc9c1cdc518e77d3d => 32
	i64 14644440854989303794, ; 212: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 87
	i64 14792063746108907174, ; 213: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 112
	i64 14852515768018889994, ; 214: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 70
	i64 14954917835170835695, ; 215: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 23
	i64 14987728460634540364, ; 216: System.IO.Compression.dll => 0xcfff1ba06622494c => 115
	i64 14988210264188246988, ; 217: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 72
	i64 15133485256822086103, ; 218: System.Linq.dll => 0xd204f0a9127dd9d7 => 124
	i64 15241747024500257992, ; 219: Syncfusion.SfMaskedEdit.XForms.dll => 0xd385902a1fb474c8 => 37
	i64 15370334346939861994, ; 220: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 69
	i64 15377983283090003614, ; 221: Syncfusion.SfBusyIndicator.Android.dll => 0xd5699251e679969e => 33
	i64 15391712275433856905, ; 222: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 23
	i64 15526743539506359484, ; 223: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 9
	i64 15582737692548360875, ; 224: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 85
	i64 15609085926864131306, ; 225: System.dll => 0xd89e9cf3334914ea => 48
	i64 15777549416145007739, ; 226: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 97
	i64 15810740023422282496, ; 227: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 110
	i64 16154507427712707110, ; 228: System => 0xe03056ea4e39aa26 => 48
	i64 16565028646146589191, ; 229: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 117
	i64 16621146507174665210, ; 230: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 67
	i64 16677317093839702854, ; 231: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 92
	i64 16787552971463248837, ; 232: Syncfusion.SfPicker.XForms.Android.dll => 0xe8f95e7bb81ecbc5 => 42
	i64 16822611501064131242, ; 233: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 114
	i64 16833383113903931215, ; 234: mscorlib => 0xe99c30c1484d7f4f => 26
	i64 16890310621557459193, ; 235: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 123
	i64 17024911836938395553, ; 236: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 56
	i64 17031351772568316411, ; 237: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 90
	i64 17037200463775726619, ; 238: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 78
	i64 17265840599643471622, ; 239: Autofac.Extensions.DependencyInjection.dll => 0xef9c968c0a443f06 => 18
	i64 17333249706306540043, ; 240: System.Diagnostics.Tracing.dll => 0xf08c12c5bb8b920b => 126
	i64 17544493274320527064, ; 241: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 61
	i64 17685921127322830888, ; 242: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 14
	i64 17704177640604968747, ; 243: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 86
	i64 17710060891934109755, ; 244: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 84
	i64 17712670374920797664, ; 245: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 125
	i64 17882897186074144999, ; 246: FormsViewGroup => 0xf82cd03e3ac830e7 => 20
	i64 17892495832318972303, ; 247: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 110
	i64 17922441377465642371, ; 248: XStore.Service.dll => 0xf8b94d79c39a2d83 => 2
	i64 17928294245072900555, ; 249: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 116
	i64 18025913125965088385, ; 250: System.Threading => 0xfa28e87b91334681 => 13
	i64 18116111925905154859, ; 251: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 60
	i64 18121036031235206392, ; 252: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 90
	i64 18129453464017766560, ; 253: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 120
	i64 18245806341561545090, ; 254: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 12
	i64 18305135509493619199, ; 255: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 91
	i64 18380184030268848184, ; 256: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 103
	i64 18409051266390776985 ; 257: Syncfusion.SfTabView.XForms.Android.dll => 0xff7a1697692d5c99 => 44
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [258 x i32] [
	i32 74, i32 29, i32 25, i32 64, i32 96, i32 97, i32 113, i32 83, ; 0..7
	i32 10, i32 77, i32 34, i32 73, i32 118, i32 109, i32 128, i32 111, ; 8..15
	i32 59, i32 16, i32 57, i32 85, i32 78, i32 19, i32 27, i32 127, ; 16..23
	i32 58, i32 96, i32 55, i32 84, i32 31, i32 27, i32 89, i32 62, ; 24..31
	i32 73, i32 119, i32 12, i32 81, i32 30, i32 68, i32 101, i32 51, ; 32..39
	i32 54, i32 52, i32 26, i32 44, i32 93, i32 107, i32 111, i32 80, ; 40..47
	i32 56, i32 50, i32 24, i32 17, i32 99, i32 98, i32 49, i32 51, ; 48..55
	i32 1, i32 95, i32 35, i32 74, i32 29, i32 127, i32 121, i32 120, ; 56..63
	i32 121, i32 2, i32 103, i32 61, i32 54, i32 98, i32 43, i32 45, ; 64..71
	i32 4, i32 4, i32 108, i32 106, i32 87, i32 88, i32 101, i32 100, ; 72..79
	i32 14, i32 67, i32 46, i32 105, i32 65, i32 33, i32 93, i32 41, ; 80..87
	i32 18, i32 82, i32 109, i32 20, i32 122, i32 83, i32 81, i32 62, ; 88..95
	i32 71, i32 119, i32 77, i32 24, i32 0, i32 53, i32 50, i32 31, ; 96..103
	i32 79, i32 76, i32 124, i32 5, i32 53, i32 107, i32 106, i32 15, ; 104..111
	i32 22, i32 41, i32 11, i32 57, i32 117, i32 6, i32 80, i32 47, ; 112..119
	i32 114, i32 8, i32 21, i32 6, i32 39, i32 38, i32 19, i32 7, ; 120..127
	i32 66, i32 92, i32 28, i32 100, i32 21, i32 22, i32 91, i32 116, ; 128..135
	i32 47, i32 40, i32 105, i32 58, i32 38, i32 40, i32 42, i32 123, ; 136..143
	i32 49, i32 39, i32 68, i32 88, i32 3, i32 25, i32 65, i32 118, ; 144..151
	i32 128, i32 15, i32 71, i32 9, i32 122, i32 99, i32 69, i32 7, ; 152..159
	i32 59, i32 17, i32 126, i32 46, i32 52, i32 104, i32 3, i32 70, ; 160..167
	i32 94, i32 0, i32 125, i32 104, i32 79, i32 55, i32 1, i32 36, ; 168..175
	i32 45, i32 76, i32 34, i32 113, i32 8, i32 102, i32 43, i32 36, ; 176..183
	i32 75, i32 86, i32 72, i32 63, i32 115, i32 64, i32 35, i32 10, ; 184..191
	i32 16, i32 28, i32 102, i32 66, i32 112, i32 60, i32 95, i32 30, ; 192..199
	i32 11, i32 37, i32 75, i32 108, i32 32, i32 63, i32 13, i32 89, ; 200..207
	i32 94, i32 5, i32 82, i32 32, i32 87, i32 112, i32 70, i32 23, ; 208..215
	i32 115, i32 72, i32 124, i32 37, i32 69, i32 33, i32 23, i32 9, ; 216..223
	i32 85, i32 48, i32 97, i32 110, i32 48, i32 117, i32 67, i32 92, ; 224..231
	i32 42, i32 114, i32 26, i32 123, i32 56, i32 90, i32 78, i32 18, ; 232..239
	i32 126, i32 61, i32 14, i32 86, i32 84, i32 125, i32 20, i32 110, ; 240..247
	i32 2, i32 116, i32 13, i32 60, i32 90, i32 120, i32 12, i32 91, ; 248..255
	i32 103, i32 44 ; 256..257
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
