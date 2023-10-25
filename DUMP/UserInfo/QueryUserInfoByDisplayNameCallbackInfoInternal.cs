using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	internal struct QueryUserInfoByDisplayNameCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoByDisplayNameCallbackInfo>, ISettable<QueryUserInfoByDisplayNameCallbackInfo>, IDisposable
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000056")]
		public Result ResultCode
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000057")]
		public object ClientData
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x4AD680", Offset = "0x4ABC80", VA = "0x1804AD680")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x4AD890", Offset = "0x4ABE90", VA = "0x1804AD890")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x17000058")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000059")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x4AD790", Offset = "0x4ABD90", VA = "0x1804AD790")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x4AD990", Offset = "0x4ABF90", VA = "0x1804AD990")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005A")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x4AD810", Offset = "0x4ABE10", VA = "0x1804AD810")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x4ADA40", Offset = "0x4AC040", VA = "0x1804ADA40")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005B")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x4AD720", Offset = "0x4ABD20", VA = "0x1804AD720")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x4AD930", Offset = "0x4ABF30", VA = "0x1804AD930")]
			set
			{
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x4AD4C0", Offset = "0x4ABAC0", VA = "0x1804AD4C0", Slot = "6")]
		public void Set(ref QueryUserInfoByDisplayNameCallbackInfo other)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x4AD550", Offset = "0x4ABB50", VA = "0x1804AD550", Slot = "7")]
		public void Set(ref QueryUserInfoByDisplayNameCallbackInfo? other)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x4AD320", Offset = "0x4AB920", VA = "0x1804AD320", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4AD490", Offset = "0x4ABA90", VA = "0x1804AD490", Slot = "5")]
		public void Get(out QueryUserInfoByDisplayNameCallbackInfo output)
		{
		}

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_DisplayName;
	}
}
