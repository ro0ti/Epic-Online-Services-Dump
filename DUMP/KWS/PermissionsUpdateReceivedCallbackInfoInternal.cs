using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	internal struct PermissionsUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PermissionsUpdateReceivedCallbackInfo>, ISettable<PermissionsUpdateReceivedCallbackInfo>, IDisposable
	{
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D7")]
		public object ClientData
		{
			[Token(Token = "0x6001F66")]
			[Address(RVA = "0x531100", Offset = "0x52F700", VA = "0x180531100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F67")]
			[Address(RVA = "0x5313A0", Offset = "0x52F9A0", VA = "0x1805313A0")]
			set
			{
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x000087A4 File Offset: 0x000069A4
		[Token(Token = "0x170008D8")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6001F68")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008D9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x5312B0", Offset = "0x52F8B0", VA = "0x1805312B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F6A")]
			[Address(RVA = "0x531520", Offset = "0x52FB20", VA = "0x180531520")]
			set
			{
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008DA")]
		public Utf8String KWSUserId
		{
			[Token(Token = "0x6001F6B")]
			[Address(RVA = "0x531240", Offset = "0x52F840", VA = "0x180531240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F6C")]
			[Address(RVA = "0x5314C0", Offset = "0x52FAC0", VA = "0x1805314C0")]
			set
			{
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008DB")]
		public Utf8String DateOfBirth
		{
			[Token(Token = "0x6001F6D")]
			[Address(RVA = "0x531170", Offset = "0x52F770", VA = "0x180531170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F6E")]
			[Address(RVA = "0x531400", Offset = "0x52FA00", VA = "0x180531400")]
			set
			{
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x000087BC File Offset: 0x000069BC
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008DC")]
		public bool IsMinor
		{
			[Token(Token = "0x6001F6F")]
			[Address(RVA = "0x5311E0", Offset = "0x52F7E0", VA = "0x1805311E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F70")]
			[Address(RVA = "0x531460", Offset = "0x52FA60", VA = "0x180531460")]
			set
			{
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008DD")]
		public Utf8String ParentEmail
		{
			[Token(Token = "0x6001F71")]
			[Address(RVA = "0x531330", Offset = "0x52F930", VA = "0x180531330")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F72")]
			[Address(RVA = "0x531580", Offset = "0x52FB80", VA = "0x180531580")]
			set
			{
			}
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x530F30", Offset = "0x52F530", VA = "0x180530F30", Slot = "6")]
		public void Set(ref PermissionsUpdateReceivedCallbackInfo other)
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x530CD0", Offset = "0x52F2D0", VA = "0x180530CD0", Slot = "7")]
		public void Set(ref PermissionsUpdateReceivedCallbackInfo? other)
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x530C30", Offset = "0x52F230", VA = "0x180530C30", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x530CB0", Offset = "0x52F2B0", VA = "0x180530CB0", Slot = "5")]
		public void Get(out PermissionsUpdateReceivedCallbackInfo output)
		{
		}

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_KWSUserId;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_DateOfBirth;

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x20")]
		private int m_IsMinor;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_ParentEmail;
	}
}
