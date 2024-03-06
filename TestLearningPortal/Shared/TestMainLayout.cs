using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Shared;

namespace TestLearningPortal
{
	[Collection("LearningPortal")]
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
