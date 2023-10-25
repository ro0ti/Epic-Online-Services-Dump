using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	internal struct GetToggleFriendsButtonOptionsInternal : ISettable<GetToggleFriendsButtonOptions>, IDisposable
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref GetToggleFriendsButtonOptions other)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x4A6670", Offset = "0x4A4C70", VA = "0x1804A6670", Slot = "5")]
		public void Set(ref GetToggleFriendsButtonOptions? other)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
