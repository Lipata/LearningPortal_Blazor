using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Pages;
using LearningPortal.LearningApp;

namespace TestLearningPortal
{
	[Collection("LearningPortal")]
	public class TestDashboard
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbRatingModule),
				typeof(IgbChipModule),
				typeof(IgbCheckboxModule));
			ctx.Services.AddScoped<ILearningAppService>(sp => new MockLearningAppService());
			var componentUnderTest = ctx.RenderComponent<Dashboard>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
