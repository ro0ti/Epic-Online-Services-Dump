using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	internal struct SessionSearchSetMaxResultsOptionsInternal : ISettable<SessionSearchSetMaxResultsOptions>, IDisposable
	{
		// Token: 0x17000299 RID: 665
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000299")]
		public uint MaxSearchResults
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SessionSearchSetMaxResultsOptions other)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x4CC760", Offset = "0x4CAD60", VA = "0x1804CC760", Slot = "5")]
		public void Set(ref SessionSearchSetMaxResultsOptions? other)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0x4")]
		private uint m_MaxSearchResults;
	}
}
