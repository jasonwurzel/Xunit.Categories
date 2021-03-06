﻿using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.Categories
{
	public class DocumentationDiscoverer : ITraitDiscoverer
	{
		internal const string DiscovererTypeName = DiscovererUtil.AssemblyName + "." + nameof(DocumentationDiscoverer);

		public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
		{
			var workItemId = traitAttribute.GetNamedArgument<string>("WorkItemIdId");


			yield return new KeyValuePair<string, string>("Category", "Documentation");

			if (!string.IsNullOrWhiteSpace(workItemId))
				yield return new KeyValuePair<string, string>("Documentation", workItemId);

		}
	}
}