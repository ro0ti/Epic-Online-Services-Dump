using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006ED RID: 1773
	[Token(Token = "0x20006ED")]
	internal struct AddExternalIntegrityCatalogOptionsInternal : ISettable<AddExternalIntegrityCatalogOptions>, IDisposable
	{
		// Token: 0x17000D93 RID: 3475
		// (set) Token: 0x06002D88 RID: 11656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D93")]
		public Utf8String PathToBinFile
		{
			[Token(Token = "0x6002D88")]
			[Address(RVA = "0x56B240", Offset = "0x569840", VA = "0x18056B240")]
			set
			{
			}
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D89")]
		[Address(RVA = "0x56B1E0", Offset = "0x5697E0", VA = "0x18056B1E0", Slot = "4")]
		public void Set(ref AddExternalIntegrityCatalogOptions other)
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D8A")]
		[Address(RVA = "0x56B140", Offset = "0x569740", VA = "0x18056B140", Slot = "5")]
		public void Set(ref AddExternalIntegrityCatalogOptions? other)
		{
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D8B")]
		[Address(RVA = "0x56B0F0", Offset = "0x5696F0", VA = "0x18056B0F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PathToBinFile;
	}
}
