using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	internal struct CopySessionHandleForPresenceOptionsInternal : ISettable<CopySessionHandleForPresenceOptions>, IDisposable
	{
		// Token: 0x170001B7 RID: 439
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001B7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x4BB140", Offset = "0x4B9740", VA = "0x1804BB140")]
			set
			{
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x4BB0E0", Offset = "0x4B96E0", VA = "0x1804BB0E0", Slot = "4")]
		public void Set(ref CopySessionHandleForPresenceOptions other)
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x4BB040", Offset = "0x4B9640", VA = "0x1804BB040", Slot = "5")]
		public void Set(ref CopySessionHandleForPresenceOptions? other)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x4BAFF0", Offset = "0x4B95F0", VA = "0x1804BAFF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
