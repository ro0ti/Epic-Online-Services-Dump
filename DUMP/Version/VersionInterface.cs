using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Version
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public sealed class VersionInterface
	{
		// Token: 0x0600037F RID: 895 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x4B8180", Offset = "0x4B6780", VA = "0x1804B8180")]
		public static Utf8String GetVersion()
		{
			return null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public VersionInterface()
		{
		}

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String CompanyName;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Utf8String CopyrightString;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		public const int MajorVersion = 1;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		public const int MinorVersion = 16;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		public const int PatchVersion = 0;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Utf8String ProductIdentifier;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Utf8String ProductName;
	}
}
