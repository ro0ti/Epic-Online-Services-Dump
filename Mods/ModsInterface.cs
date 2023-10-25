using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	public sealed class ModsInterface : Handle
	{
		// Token: 0x060017A2 RID: 6050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public ModsInterface()
		{
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public ModsInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00006B84 File Offset: 0x00004D84
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x518F60", Offset = "0x517560", VA = "0x180518F60")]
		public Result CopyModInfo(ref CopyModInfoOptions options, out ModInfo? outEnumeratedMods)
		{
			return Result.Success;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x5190B0", Offset = "0x5176B0", VA = "0x1805190B0")]
		public void EnumerateMods(ref EnumerateModsOptions options, object clientData, OnEnumerateModsCallback completionDelegate)
		{
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x5192C0", Offset = "0x5178C0", VA = "0x1805192C0")]
		public void InstallMod(ref InstallModOptions options, object clientData, OnInstallModCallback completionDelegate)
		{
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A7")]
		[Address(RVA = "0x519770", Offset = "0x517D70", VA = "0x180519770")]
		public void UninstallMod(ref UninstallModOptions options, object clientData, OnUninstallModCallback completionDelegate)
		{
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x519940", Offset = "0x517F40", VA = "0x180519940")]
		public void UpdateMod(ref UpdateModOptions options, object clientData, OnUpdateModCallback completionDelegate)
		{
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x519490", Offset = "0x517A90", VA = "0x180519490")]
		[MonoPInvokeCallback(typeof(OnEnumerateModsCallbackInternal))]
		internal static void OnEnumerateModsCallbackInternalImplementation(ref EnumerateModsCallbackInfoInternal data)
		{
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x519530", Offset = "0x517B30", VA = "0x180519530")]
		[MonoPInvokeCallback(typeof(OnInstallModCallbackInternal))]
		internal static void OnInstallModCallbackInternalImplementation(ref InstallModCallbackInfoInternal data)
		{
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x5195F0", Offset = "0x517BF0", VA = "0x1805195F0")]
		[MonoPInvokeCallback(typeof(OnUninstallModCallbackInternal))]
		internal static void OnUninstallModCallbackInternalImplementation(ref UninstallModCallbackInfoInternal data)
		{
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x5196B0", Offset = "0x517CB0", VA = "0x1805196B0")]
		[MonoPInvokeCallback(typeof(OnUpdateModCallbackInternal))]
		internal static void OnUpdateModCallbackInternalImplementation(ref UpdateModCallbackInfoInternal data)
		{
		}

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		public const int CopymodinfoApiLatest = 1;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		public const int EnumeratemodsApiLatest = 1;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		public const int InstallmodApiLatest = 1;

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		public const int ModIdentifierApiLatest = 1;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		public const int ModinfoApiLatest = 1;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		public const int UninstallmodApiLatest = 1;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		public const int UpdatemodApiLatest = 1;
	}
}
