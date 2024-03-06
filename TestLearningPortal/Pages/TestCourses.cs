using Bunit;
using Microsoft.Extensions.DependencyInjection;
using LearningPortal.Pages;
using LearningPortal.LearningApp;

namespace TestLearningPortal
{
	[Collection("LearningPortal")]
	public class TestCourses
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbRatingModule),
				typeof(IgbChipModule),
				typeof(IgbAvatarModule),
				typeof(IgbAccordionModule),
				typeof(IgbExpansionPanelModule));
			ctx.Services.AddScoped<ILearningAppService>(sp => new MockLearningAppService());
			var componentUnderTest = ctx.RenderComponent<Courses>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
