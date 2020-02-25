// Generated from /home/angelica/RiderProjects/Documo/Documo/Grammar/Documo.g4 by ANTLR 4.8
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link DocumoParser}.
 */
public interface DocumoListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link DocumoParser#stmt}.
	 * @param ctx the parse tree
	 */
	void enterStmt(DocumoParser.StmtContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#stmt}.
	 * @param ctx the parse tree
	 */
	void exitStmt(DocumoParser.StmtContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#placeholder}.
	 * @param ctx the parse tree
	 */
	void enterPlaceholder(DocumoParser.PlaceholderContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#placeholder}.
	 * @param ctx the parse tree
	 */
	void exitPlaceholder(DocumoParser.PlaceholderContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#repeatingSection}.
	 * @param ctx the parse tree
	 */
	void enterRepeatingSection(DocumoParser.RepeatingSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#repeatingSection}.
	 * @param ctx the parse tree
	 */
	void exitRepeatingSection(DocumoParser.RepeatingSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#imagePlaceholder}.
	 * @param ctx the parse tree
	 */
	void enterImagePlaceholder(DocumoParser.ImagePlaceholderContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#imagePlaceholder}.
	 * @param ctx the parse tree
	 */
	void exitImagePlaceholder(DocumoParser.ImagePlaceholderContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#conditionalPlaceholder}.
	 * @param ctx the parse tree
	 */
	void enterConditionalPlaceholder(DocumoParser.ConditionalPlaceholderContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#conditionalPlaceholder}.
	 * @param ctx the parse tree
	 */
	void exitConditionalPlaceholder(DocumoParser.ConditionalPlaceholderContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#startRepeatingSection}.
	 * @param ctx the parse tree
	 */
	void enterStartRepeatingSection(DocumoParser.StartRepeatingSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#startRepeatingSection}.
	 * @param ctx the parse tree
	 */
	void exitStartRepeatingSection(DocumoParser.StartRepeatingSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#endRepeatingSection}.
	 * @param ctx the parse tree
	 */
	void enterEndRepeatingSection(DocumoParser.EndRepeatingSectionContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#endRepeatingSection}.
	 * @param ctx the parse tree
	 */
	void exitEndRepeatingSection(DocumoParser.EndRepeatingSectionContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#object}.
	 * @param ctx the parse tree
	 */
	void enterObject(DocumoParser.ObjectContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#object}.
	 * @param ctx the parse tree
	 */
	void exitObject(DocumoParser.ObjectContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#objectFieldAccess}.
	 * @param ctx the parse tree
	 */
	void enterObjectFieldAccess(DocumoParser.ObjectFieldAccessContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#objectFieldAccess}.
	 * @param ctx the parse tree
	 */
	void exitObjectFieldAccess(DocumoParser.ObjectFieldAccessContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#objectName}.
	 * @param ctx the parse tree
	 */
	void enterObjectName(DocumoParser.ObjectNameContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#objectName}.
	 * @param ctx the parse tree
	 */
	void exitObjectName(DocumoParser.ObjectNameContext ctx);
	/**
	 * Enter a parse tree produced by {@link DocumoParser#objectField}.
	 * @param ctx the parse tree
	 */
	void enterObjectField(DocumoParser.ObjectFieldContext ctx);
	/**
	 * Exit a parse tree produced by {@link DocumoParser#objectField}.
	 * @param ctx the parse tree
	 */
	void exitObjectField(DocumoParser.ObjectFieldContext ctx);
}