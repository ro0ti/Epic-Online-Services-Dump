using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002A8 RID: 680
	[Token(Token = "0x20002A8")]
	internal struct CreatePresenceModificationOptionsInternal : ISettable<CreatePresenceModificationOptions>, IDisposable
	{
		// Token: 0x170004DA RID: 1242
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004DA")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001291")]
			[Address(RVA = "0x4EEBA0", Offset = "0x4ED1A0", VA = "0x1804EEBA0")]
			set
			{
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x4EEB40", Offset = "0x4ED140", VA = "0x1804EEB40", Slot = "4")]
		public void Set(ref CreatePresenceModificationOptions other)
		{
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x4EEAA0", Offset = "0x4ED0A0", VA = "0x1804EEAA0", Slot = "5")]
		public void Set(ref CreatePresenceModificationOptions? other)
		{
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x4EEA50", Offset = "0x4ED050", VA = "0x1804EEA50", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
