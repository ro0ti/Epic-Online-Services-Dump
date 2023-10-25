using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public abstract class Handle : IEquatable<Handle>, IFormattable
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000022DC File Offset: 0x000004DC
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public IntPtr InnerHandle
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public Handle()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x49FCF0", Offset = "0x49E2F0", VA = "0x18049FCF0")]
		public Handle(IntPtr innerHandle)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4A68F0", Offset = "0x4A4EF0", VA = "0x1804A68F0")]
		public static bool operator ==(Handle left, Handle right)
		{
			return default(bool);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4A6910", Offset = "0x4A4F10", VA = "0x1804A6910")]
		public static bool operator !=(Handle left, Handle right)
		{
			return default(bool);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4A6710", Offset = "0x4A4D10", VA = "0x1804A6710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4A6870", Offset = "0x4A4E70", VA = "0x1804A6870", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4A67A0", Offset = "0x4A4DA0", VA = "0x1804A67A0", Slot = "4")]
		public bool Equals(Handle other)
		{
			return default(bool);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4A68A0", Offset = "0x4A4EA0", VA = "0x1804A68A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4A68C0", Offset = "0x4A4EC0", VA = "0x1804A68C0", Slot = "6")]
		public virtual string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
