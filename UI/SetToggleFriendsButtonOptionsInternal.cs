using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	internal struct SetToggleFriendsButtonOptionsInternal : ISettable<SetToggleFriendsButtonOptions>, IDisposable
	{
		// Token: 0x170000E2 RID: 226
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000E2")]
		public InputStateButtonFlags ButtonCombination
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SetToggleFriendsButtonOptions other)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x4AFC10", Offset = "0x4AE210", VA = "0x1804AFC10", Slot = "5")]
		public void Set(ref SetToggleFriendsButtonOptions? other)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x4")]
		private InputStateButtonFlags m_ButtonCombination;
	}
}
