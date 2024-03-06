using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Pages;

namespace TestLearningPortal
{
	[Collection("LearningPortal")]
	public class TestProgress
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Progress>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
