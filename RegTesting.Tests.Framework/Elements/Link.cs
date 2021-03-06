﻿using OpenQA.Selenium;
using RegTesting.Tests.Framework.Enums;
using RegTesting.Tests.Framework.Logic;

namespace RegTesting.Tests.Framework.Elements
{
	public class Link : BasicPageElement
	{

		public Link(By objBy, IWebDriver webDriver, WaitModel waitModel, BasePageObject parentPageObject, ClickBehaviours clickBehaviour = ClickBehaviours.Default)
			: base(objBy, webDriver, waitModel, parentPageObject, clickBehaviour)
		{
		}
	}
}
