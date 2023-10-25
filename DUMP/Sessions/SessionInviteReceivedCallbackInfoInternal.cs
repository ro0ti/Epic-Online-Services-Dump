using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	internal struct SessionInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionInviteReceivedCallbackInfo>, ISettable<SessionInviteReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000267")]
		public object ClientData
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x4C9BE0", Offset = "0x4C81E0", VA = "0x1804C9BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x4C9DC0", Offset = "0x4C83C0", VA = "0x1804C9DC0")]
			set
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x17000268")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000269")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x4C9CC0", Offset = "0x4C82C0", VA = "0x1804C9CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x4C9E80", Offset = "0x4C8480", VA = "0x1804C9E80")]
			set
			{
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700026A")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x4C9D40", Offset = "0x4C8340", VA = "0x1804C9D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x4C9EE0", Offset = "0x4C84E0", VA = "0x1804C9EE0")]
			set
			{
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700026B")]
		public Utf8String InviteId
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x4C9C50", Offset = "0x4C8250", VA = "0x1804C9C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x4C9E20", Offset = "0x4C8420", VA = "0x1804C9E20")]
			set
			{
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x4C9AA0", Offset = "0x4C80A0", VA = "0x1804C9AA0", Slot = "6")]
		public void Set(ref SessionInviteReceivedCallbackInfo other)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x4C98F0", Offset = "0x4C7EF0", VA = "0x1804C98F0", Slot = "7")]
		public void Set(ref SessionInviteReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x4C9860", Offset = "0x4C7E60", VA = "0x1804C9860", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x4C98D0", Offset = "0x4C7ED0", VA = "0x1804C98D0", Slot = "5")]
		public void Get(out SessionInviteReceivedCallbackInfo output)
		{
		}

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_InviteId;
	}
}
