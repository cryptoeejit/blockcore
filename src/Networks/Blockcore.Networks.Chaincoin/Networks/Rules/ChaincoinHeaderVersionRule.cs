using Blockcore.Consensus;
using Blockcore.Consensus.Chain;
using Blockcore.Consensus.Rules;
using Blockcore.Features.Consensus.Rules.CommonRules;
using Blockcore.Utilities;
using Chaincoin.Networks.Setup;
using Microsoft.Extensions.Logging;

namespace Chaincoin.Networks.Rules
{
   /// <summary>
   /// Checks if <see cref="ChaincoinMain"/> network block's header has a valid block version.
   /// </summary>
   public class ChaincoinHeaderVersionRule : HeaderVersionRule
   {
      /// <inheritdoc />
      /// <exception cref="ConsensusErrors.BadVersion">Thrown if block's version is outdated or otherwise invalid.</exception>
      public override void Run(RuleContext context)
      {
         //Guard.NotNull(context.ValidationContext.ChainedHeaderToValidate, nameof(context.ValidationContext.ChainedHeaderToValidate));

         //ChainedHeader chainedHeader = context.ValidationContext.ChainedHeaderToValidate;

      }
   }
}
