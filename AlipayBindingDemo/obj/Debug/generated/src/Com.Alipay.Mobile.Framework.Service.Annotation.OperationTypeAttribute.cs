using System;

namespace Com.Alipay.Mobile.Framework.Service.Annotation {

	[global::Android.Runtime.Annotation ("com.alipay.mobile.framework.service.annotation.OperationType")]
	public partial class OperationTypeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
