using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	public sealed class KWSInterface : Handle
	{
		// Token: 0x06001F09 RID: 7945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public KWSInterface()
		{
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public KWSInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x000086E4 File Offset: 0x000068E4
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x524CC0", Offset = "0x5232C0", VA = "0x180524CC0")]
		public ulong AddNotifyPermissionsUpdateReceived(ref AddNotifyPermissionsUpdateReceivedOptions options, object clientData, OnPermissionsUpdateReceivedCallback notificationFn)
		{
			return 0UL;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x000086FC File Offset: 0x000068FC
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x524E80", Offset = "0x523480", VA = "0x180524E80")]
		public Result CopyPermissionByIndex(ref CopyPermissionByIndexOptions options, out PermissionStatus? outPermission)
		{
			return Result.Success;
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x524FD0", Offset = "0x5235D0", VA = "0x180524FD0")]
		public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate)
		{
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00008714 File Offset: 0x00006914
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x5251A0", Offset = "0x5237A0", VA = "0x1805251A0")]
		public Result GetPermissionByKey(ref GetPermissionByKeyOptions options, out KWSPermissionStatus outPermission)
		{
			return Result.Success;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0000872C File Offset: 0x0000692C
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x525270", Offset = "0x523870", VA = "0x180525270")]
		public int GetPermissionsCount(ref GetPermissionsCountOptions options)
		{
			return 0;
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F10")]
		[Address(RVA = "0x525740", Offset = "0x523D40", VA = "0x180525740")]
		public void QueryAgeGate(ref QueryAgeGateOptions options, object clientData, OnQueryAgeGateCallback completionDelegate)
		{
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F11")]
		[Address(RVA = "0x5258F0", Offset = "0x523EF0", VA = "0x1805258F0")]
		public void QueryPermissions(ref QueryPermissionsOptions options, object clientData, OnQueryPermissionsCallback completionDelegate)
		{
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F12")]
		[Address(RVA = "0x525AF0", Offset = "0x5240F0", VA = "0x180525AF0")]
		public void RemoveNotifyPermissionsUpdateReceived(ulong inId)
		{
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F13")]
		[Address(RVA = "0x525B60", Offset = "0x524160", VA = "0x180525B60")]
		public void RequestPermissions(ref RequestPermissionsOptions options, object clientData, OnRequestPermissionsCallback completionDelegate)
		{
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F14")]
		[Address(RVA = "0x525DD0", Offset = "0x5243D0", VA = "0x180525DD0")]
		public void UpdateParentEmail(ref UpdateParentEmailOptions options, object clientData, OnUpdateParentEmailCallback completionDelegate)
		{
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F15")]
		[Address(RVA = "0x525350", Offset = "0x523950", VA = "0x180525350")]
		[MonoPInvokeCallback(typeof(OnCreateUserCallbackInternal))]
		internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data)
		{
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F16")]
		[Address(RVA = "0x525400", Offset = "0x523A00", VA = "0x180525400")]
		[MonoPInvokeCallback(typeof(OnPermissionsUpdateReceivedCallbackInternal))]
		internal static void OnPermissionsUpdateReceivedCallbackInternalImplementation(ref PermissionsUpdateReceivedCallbackInfoInternal data)
		{
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x5254B0", Offset = "0x523AB0", VA = "0x1805254B0")]
		[MonoPInvokeCallback(typeof(OnQueryAgeGateCallbackInternal))]
		internal static void OnQueryAgeGateCallbackInternalImplementation(ref QueryAgeGateCallbackInfoInternal data)
		{
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x525550", Offset = "0x523B50", VA = "0x180525550")]
		[MonoPInvokeCallback(typeof(OnQueryPermissionsCallbackInternal))]
		internal static void OnQueryPermissionsCallbackInternalImplementation(ref QueryPermissionsCallbackInfoInternal data)
		{
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x525600", Offset = "0x523C00", VA = "0x180525600")]
		[MonoPInvokeCallback(typeof(OnRequestPermissionsCallbackInternal))]
		internal static void OnRequestPermissionsCallbackInternalImplementation(ref RequestPermissionsCallbackInfoInternal data)
		{
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x5256A0", Offset = "0x523CA0", VA = "0x1805256A0")]
		[MonoPInvokeCallback(typeof(OnUpdateParentEmailCallbackInternal))]
		internal static void OnUpdateParentEmailCallbackInternalImplementation(ref UpdateParentEmailCallbackInfoInternal data)
		{
		}

		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		public const int AddnotifypermissionsupdatereceivedApiLatest = 1;

		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		public const int CopypermissionbyindexApiLatest = 1;

		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		public const int CreateuserApiLatest = 1;

		// Token: 0x04000DC9 RID: 3529
		[Token(Token = "0x4000DC9")]
		public const int GetpermissionbykeyApiLatest = 1;

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		public const int GetpermissionscountApiLatest = 1;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		public const int MaxPermissionLength = 32;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		public const int MaxPermissions = 16;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		public const int PermissionstatusApiLatest = 1;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		public const int QueryagegateApiLatest = 1;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		public const int QuerypermissionsApiLatest = 1;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		public const int RequestpermissionsApiLatest = 1;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		public const int UpdateparentemailApiLatest = 1;
	}
}
