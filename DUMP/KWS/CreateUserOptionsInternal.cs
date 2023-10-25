using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.KWS
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	internal struct CreateUserOptionsInternal : ISettable<CreateUserOptions>, IDisposable
	{
		// Token: 0x170008C4 RID: 2244
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008C4")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x522C80", Offset = "0x521280", VA = "0x180522C80")]
			set
			{
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008C5")]
		public Utf8String DateOfBirth
		{
			[Token(Token = "0x6001EF5")]
			[Address(RVA = "0x522C20", Offset = "0x521220", VA = "0x180522C20")]
			set
			{
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008C6")]
		public Utf8String ParentEmail
		{
			[Token(Token = "0x6001EF6")]
			[Address(RVA = "0x522CE0", Offset = "0x5212E0", VA = "0x180522CE0")]
			set
			{
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x522B20", Offset = "0x521120", VA = "0x180522B20", Slot = "4")]
		public void Set(ref CreateUserOptions other)
		{
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x5229C0", Offset = "0x520FC0", VA = "0x1805229C0", Slot = "5")]
		public void Set(ref CreateUserOptions? other)
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x522950", Offset = "0x520F50", VA = "0x180522950", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_DateOfBirth;

		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ParentEmail;
	}
}
