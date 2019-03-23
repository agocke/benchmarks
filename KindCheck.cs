
using BenchmarkDotNet.Attributes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace benchmarks
{
    public class KindCheck
    {
        public static CSharpSyntaxNode[] Nodes { get; } = new CSharpSyntaxNode[]
        {
            SyntaxFactory.TypeCref(SyntaxFactory.IdentifierName("T")),
            SyntaxFactory.ParameterList(default),
        };

        [ParamsSource(nameof(Nodes))]
        public CSharpSyntaxNode Node;

        [Benchmark]
        public object KindSwitch()
        {
            var node = Node;
            switch (node.Kind())
            {
                case SyntaxKind.TypeCref:
                    return ((TypeCrefSyntax)node).Type;
                case SyntaxKind.QualifiedCref:
                case SyntaxKind.NameMemberCref:
                case SyntaxKind.IndexerMemberCref:
                case SyntaxKind.OperatorMemberCref:
                case SyntaxKind.ConversionOperatorMemberCref:
                case SyntaxKind.CrefParameterList:
                case SyntaxKind.CrefBracketedParameterList:
                case SyntaxKind.CrefParameter:
                case SyntaxKind.IdentifierName:
                case SyntaxKind.QualifiedName:
                case SyntaxKind.GenericName:
                case SyntaxKind.TypeArgumentList:
                case SyntaxKind.AliasQualifiedName:
                case SyntaxKind.PredefinedType:
                case SyntaxKind.ArrayType:
                case SyntaxKind.ArrayRankSpecifier:
                case SyntaxKind.PointerType:
                case SyntaxKind.NullableType:
                case SyntaxKind.OmittedTypeArgument:
                case SyntaxKind.ParenthesizedExpression:
                case SyntaxKind.ConditionalExpression:
                case SyntaxKind.InvocationExpression:
                case SyntaxKind.ElementAccessExpression:
                case SyntaxKind.ArgumentList:
                case SyntaxKind.BracketedArgumentList:
                case SyntaxKind.Argument:
                case SyntaxKind.NameColon:
                case SyntaxKind.CastExpression:
                case SyntaxKind.AnonymousMethodExpression:
                case SyntaxKind.SimpleLambdaExpression:
                case SyntaxKind.ParenthesizedLambdaExpression:
                case SyntaxKind.ObjectInitializerExpression:
                case SyntaxKind.CollectionInitializerExpression:
                case SyntaxKind.ArrayInitializerExpression:
                case SyntaxKind.AnonymousObjectMemberDeclarator:
                case SyntaxKind.ComplexElementInitializerExpression:
                case SyntaxKind.ObjectCreationExpression:
                case SyntaxKind.AnonymousObjectCreationExpression:
                case SyntaxKind.ArrayCreationExpression:
                case SyntaxKind.ImplicitArrayCreationExpression:
                case SyntaxKind.StackAllocArrayCreationExpression:
                case SyntaxKind.OmittedArraySizeExpression:
                case SyntaxKind.InterpolatedStringExpression:
                case SyntaxKind.ImplicitElementAccess:
                case SyntaxKind.IsPatternExpression:
                case SyntaxKind.AddExpression:
                case SyntaxKind.SubtractExpression:
                case SyntaxKind.MultiplyExpression:
                case SyntaxKind.DivideExpression:
                case SyntaxKind.ModuloExpression:
                case SyntaxKind.LeftShiftExpression:
                case SyntaxKind.RightShiftExpression:
                case SyntaxKind.LogicalOrExpression:
                case SyntaxKind.LogicalAndExpression:
                case SyntaxKind.BitwiseOrExpression:
                case SyntaxKind.BitwiseAndExpression:
                case SyntaxKind.ExclusiveOrExpression:
                case SyntaxKind.EqualsExpression:
                case SyntaxKind.NotEqualsExpression:
                case SyntaxKind.LessThanExpression:
                case SyntaxKind.LessThanOrEqualExpression:
                case SyntaxKind.GreaterThanExpression:
                case SyntaxKind.GreaterThanOrEqualExpression:
                case SyntaxKind.IsExpression:
                case SyntaxKind.AsExpression:
                case SyntaxKind.CoalesceExpression:
                case SyntaxKind.SimpleMemberAccessExpression:
                case SyntaxKind.PointerMemberAccessExpression:
                case SyntaxKind.ConditionalAccessExpression:
                case SyntaxKind.MemberBindingExpression:
                case SyntaxKind.ElementBindingExpression:
                case SyntaxKind.SimpleAssignmentExpression:
                case SyntaxKind.AddAssignmentExpression:
                case SyntaxKind.SubtractAssignmentExpression:
                case SyntaxKind.MultiplyAssignmentExpression:
                case SyntaxKind.DivideAssignmentExpression:
                case SyntaxKind.ModuloAssignmentExpression:
                case SyntaxKind.AndAssignmentExpression:
                case SyntaxKind.ExclusiveOrAssignmentExpression:
                case SyntaxKind.OrAssignmentExpression:
                case SyntaxKind.LeftShiftAssignmentExpression:
                case SyntaxKind.RightShiftAssignmentExpression:
                case SyntaxKind.UnaryPlusExpression:
                case SyntaxKind.UnaryMinusExpression:
                case SyntaxKind.BitwiseNotExpression:
                case SyntaxKind.LogicalNotExpression:
                case SyntaxKind.PreIncrementExpression:
                case SyntaxKind.PreDecrementExpression:
                case SyntaxKind.PointerIndirectionExpression:
                case SyntaxKind.AddressOfExpression:
                case SyntaxKind.PostIncrementExpression:
                case SyntaxKind.PostDecrementExpression:
                case SyntaxKind.AwaitExpression:
                case SyntaxKind.ThisExpression:
                case SyntaxKind.BaseExpression:
                case SyntaxKind.ArgListExpression:
                case SyntaxKind.NumericLiteralExpression:
                case SyntaxKind.StringLiteralExpression:
                case SyntaxKind.CharacterLiteralExpression:
                case SyntaxKind.TrueLiteralExpression:
                case SyntaxKind.FalseLiteralExpression:
                case SyntaxKind.NullLiteralExpression:
                case SyntaxKind.DefaultLiteralExpression:
                case SyntaxKind.TypeOfExpression:
                case SyntaxKind.SizeOfExpression:
                case SyntaxKind.CheckedExpression:
                case SyntaxKind.UncheckedExpression:
                case SyntaxKind.DefaultExpression:
                case SyntaxKind.MakeRefExpression:
                case SyntaxKind.RefValueExpression:
                case SyntaxKind.RefTypeExpression:
                case SyntaxKind.QueryExpression:
                case SyntaxKind.QueryBody:
                case SyntaxKind.FromClause:
                case SyntaxKind.LetClause:
                case SyntaxKind.JoinClause:
                case SyntaxKind.JoinIntoClause:
                case SyntaxKind.WhereClause:
                case SyntaxKind.OrderByClause:
                case SyntaxKind.AscendingOrdering:
                case SyntaxKind.DescendingOrdering:
                case SyntaxKind.SelectClause:
                case SyntaxKind.GroupClause:
                case SyntaxKind.QueryContinuation:
                case SyntaxKind.Block:
                case SyntaxKind.LocalDeclarationStatement:
                case SyntaxKind.VariableDeclaration:
                case SyntaxKind.VariableDeclarator:
                case SyntaxKind.EqualsValueClause:
                case SyntaxKind.ExpressionStatement:
                case SyntaxKind.EmptyStatement:
                case SyntaxKind.LabeledStatement:
                case SyntaxKind.GotoStatement:
                case SyntaxKind.GotoCaseStatement:
                case SyntaxKind.GotoDefaultStatement:
                case SyntaxKind.BreakStatement:
                case SyntaxKind.ContinueStatement:
                case SyntaxKind.ReturnStatement:
                case SyntaxKind.YieldReturnStatement:
                case SyntaxKind.YieldBreakStatement:
                case SyntaxKind.ThrowStatement:
                case SyntaxKind.WhileStatement:
                case SyntaxKind.DoStatement:
                case SyntaxKind.ForStatement:
                case SyntaxKind.ForEachStatement:
                case SyntaxKind.UsingStatement:
                case SyntaxKind.FixedStatement:
                case SyntaxKind.CheckedStatement:
                case SyntaxKind.UncheckedStatement:
                case SyntaxKind.UnsafeStatement:
                case SyntaxKind.LockStatement:
                case SyntaxKind.IfStatement:
                case SyntaxKind.ElseClause:
                case SyntaxKind.SwitchStatement:
                case SyntaxKind.SwitchSection:
                case SyntaxKind.CaseSwitchLabel:
                case SyntaxKind.DefaultSwitchLabel:
                case SyntaxKind.TryStatement:
                case SyntaxKind.CatchClause:
                case SyntaxKind.CatchDeclaration:
                case SyntaxKind.CatchFilterClause:
                case SyntaxKind.FinallyClause:
                case SyntaxKind.LocalFunctionStatement:
                case SyntaxKind.CompilationUnit:
                case SyntaxKind.GlobalStatement:
                case SyntaxKind.NamespaceDeclaration:
                case SyntaxKind.UsingDirective:
                case SyntaxKind.ExternAliasDirective:
                case SyntaxKind.AttributeList:
                case SyntaxKind.AttributeTargetSpecifier:
                case SyntaxKind.Attribute:
                case SyntaxKind.AttributeArgumentList:
                case SyntaxKind.AttributeArgument:
                case SyntaxKind.NameEquals:
                case SyntaxKind.ClassDeclaration:
                case SyntaxKind.StructDeclaration:
                case SyntaxKind.InterfaceDeclaration:
                case SyntaxKind.EnumDeclaration:
                case SyntaxKind.DelegateDeclaration:
                case SyntaxKind.BaseList:
                case SyntaxKind.SimpleBaseType:
                case SyntaxKind.TypeParameterConstraintClause:
                case SyntaxKind.ConstructorConstraint:
                case SyntaxKind.ClassConstraint:
                case SyntaxKind.StructConstraint:
                case SyntaxKind.TypeConstraint:
                case SyntaxKind.ExplicitInterfaceSpecifier:
                case SyntaxKind.EnumMemberDeclaration:
                case SyntaxKind.FieldDeclaration:
                case SyntaxKind.EventFieldDeclaration:
                case SyntaxKind.MethodDeclaration:
                case SyntaxKind.OperatorDeclaration:
                case SyntaxKind.ConversionOperatorDeclaration:
                case SyntaxKind.ConstructorDeclaration:
                case SyntaxKind.BaseConstructorInitializer:
                case SyntaxKind.ThisConstructorInitializer:
                case SyntaxKind.DestructorDeclaration:
                case SyntaxKind.PropertyDeclaration:
                case SyntaxKind.EventDeclaration:
                case SyntaxKind.IndexerDeclaration:
                case SyntaxKind.AccessorList:
                case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
                case SyntaxKind.ParameterList:
                    return ((ParameterListSyntax)node).Parameters;
                case SyntaxKind.BracketedParameterList:
                case SyntaxKind.Parameter:
                case SyntaxKind.TypeParameterList:
                case SyntaxKind.TypeParameter:
                case SyntaxKind.IncompleteMember:
                case SyntaxKind.ArrowExpressionClause:
                case SyntaxKind.Interpolation:
                case SyntaxKind.InterpolatedStringText:
                case SyntaxKind.InterpolationAlignmentClause:
                case SyntaxKind.InterpolationFormatClause:
                case SyntaxKind.ShebangDirectiveTrivia:
                case SyntaxKind.LoadDirectiveTrivia:
                case SyntaxKind.TupleType:
                case SyntaxKind.TupleElement:
                case SyntaxKind.TupleExpression:
                case SyntaxKind.SingleVariableDesignation:
                case SyntaxKind.ParenthesizedVariableDesignation:
                case SyntaxKind.ForEachVariableStatement:
                case SyntaxKind.DeclarationPattern:
                case SyntaxKind.ConstantPattern:
                case SyntaxKind.CasePatternSwitchLabel:
                case SyntaxKind.WhenClause:
                case SyntaxKind.DiscardDesignation:
                case SyntaxKind.DeclarationExpression:
                case SyntaxKind.RefExpression:
                case SyntaxKind.RefType:
                case SyntaxKind.ThrowExpression:
                case SyntaxKind.ImplicitStackAllocArrayCreationExpression:
                    return "m";

                default:
                    return null;
            }
        }

        [Benchmark]
        public object TypeSwitch()
        {
            var node = Node;
            switch (node)
            {
                case TypeCrefSyntax typeCrefSyntax:
                    return typeCrefSyntax.Type;
                case QualifiedCrefSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case NameMemberCrefSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case IndexerMemberCrefSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case OperatorMemberCrefSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case ConversionOperatorMemberCrefSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case CrefParameterListSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case CrefBracketedParameterListSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case CrefParameterSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case IdentifierNameSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case QualifiedNameSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case GenericNameSyntax nodeSyntax:
                    return nodeSyntax.SyntaxTree;
                case ParameterListSyntax parameterListSyntax:
                    return parameterListSyntax.Parameters;

                default:
                    return null;
            }
        }
    }
}