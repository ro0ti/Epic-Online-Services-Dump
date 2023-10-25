using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	internal struct ActiveSessionInfoInternal : IGettable<ActiveSessionInfo>, ISettable<ActiveSessionInfo>, IDisposable
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700019F")]
		public Utf8String SessionName
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x4B89F0", Offset = "0x4B6FF0", VA = "0x1804B89F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x4B8B30", Offset = "0x4B7130", VA = "0x1804B8B30")]
			set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x4B88E0", Offset = "0x4B6EE0", VA = "0x1804B88E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x4B8A60", Offset = "0x4B7060", VA = "0x1804B8A60")]
			set
			{
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00003674 File Offset: 0x00001874
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A1")]
		public OnlineSessionState State
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			get
			{
				return OnlineSessionState.NoSession;
			}
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0000368C File Offset: 0x0000188C
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A2")]
		public SessionDetailsInfo? SessionDetails
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x4B8960", Offset = "0x4B6F60", VA = "0x1804B8960")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x4B8AC0", Offset = "0x4B70C0", VA = "0x1804B8AC0")]
			set
			{
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x4B8780", Offset = "0x4B6D80", VA = "0x1804B8780", Slot = "5")]
		public void Set(ref ActiveSessionInfo other)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x4B8590", Offset = "0x4B6B90", VA = "0x1804B8590", Slot = "6")]
		public void Set(ref ActiveSessionInfo? other)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x4B84F0", Offset = "0x4B6AF0", VA = "0x1804B84F0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x4B8560", Offset = "0x4B6B60", VA = "0x1804B8560", Slot = "4")]
		public void Get(out ActiveSessionInfo output)
		{
		}

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x18")]
		private OnlineSessionState m_State;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_SessionDetails;
	}
}
