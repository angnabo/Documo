// Generated from /home/angelica/RiderProjects/Documo/Documo/Grammar/Documo.g4 by ANTLR 4.8
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link DocumoParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface DocumoVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link DocumoParser#stmt}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStmt(DocumoParser.StmtContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#placeholder}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitPlaceholder(DocumoParser.PlaceholderContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#repeatingSection}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitRepeatingSection(DocumoParser.RepeatingSectionContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#imagePlaceholder}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitImagePlaceholder(DocumoParser.ImagePlaceholderContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#conditionalPlaceholder}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConditionalPlaceholder(DocumoParser.ConditionalPlaceholderContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#startRepeatingSection}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitStartRepeatingSection(DocumoParser.StartRepeatingSectionContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#endRepeatingSection}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitEndRepeatingSection(DocumoParser.EndRepeatingSectionContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#object}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitObject(DocumoParser.ObjectContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#objectFieldAccess}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitObjectFieldAccess(DocumoParser.ObjectFieldAccessContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#objectName}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitObjectName(DocumoParser.ObjectNameContext ctx);
	/**
	 * Visit a parse tree produced by {@link DocumoParser#objectField}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitObjectField(DocumoParser.ObjectFieldContext ctx);
}