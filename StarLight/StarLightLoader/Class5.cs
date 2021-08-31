using System;
using System.Reflection;

// Token: 0x02000011 RID: 17
internal class Class5
{
	// Token: 0x0600004B RID: 75 RVA: 0x0001F5C4 File Offset: 0x00018DC4
	internal static void iyqA1qssMGd0L(int typemdt)
	{
		Type type = Class5.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class5.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0001E0AE File Offset: 0x000178AE
	public Class5()
	{
		Class10.mLqA1qsz6sJ2l();
		base..ctor();
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0001E221 File Offset: 0x00017A21
	// Note: this type is marked as 'beforefieldinit'.
	static Class5()
	{
		Class11.kLjw4iIsCLsZtxc4lksN0j();
		Class10.mLqA1qsz6sJ2l();
		Class5.module_0 = typeof(Class5).Assembly.ManifestModule;
	}

	// Token: 0x0400002C RID: 44
	internal static Module module_0;

	// Token: 0x02000012 RID: 18
	internal sealed class Delegate0 : MulticastDelegate
	{
		// Token: 0x0600004E RID: 78
		public extern Delegate0(object object_0, IntPtr intptr_0);

		// Token: 0x0600004F RID: 79
		public extern void Invoke(object o);

		// Token: 0x06000050 RID: 80
		public extern IAsyncResult BeginInvoke(object o, AsyncCallback callback, object @object);

		// Token: 0x06000051 RID: 81
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06000052 RID: 82 RVA: 0x0001E048 File Offset: 0x00017848
		static Delegate0()
		{
			Class11.kLjw4iIsCLsZtxc4lksN0j();
		}
	}
}
