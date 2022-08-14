﻿namespace BAMCIS.PrestoClient.Model.Sql.Tree
{
    /// <summary>
    /// From com.facebook.presto.sql.tree.Expression.java
    /// </summary>
    public abstract class Expression : Node
    {
        #region Constructors

        protected Expression(NodeLocation location) : base(location)
        { }

        #endregion

        #region Public Methods

        internal protected override R Accept<R, C>(AstVisitor<R, C> visitor, C context)
        {
            return visitor.VisitExpression(this, context);
        }

        public override string ToString()
        {
            return ExpressionFormatter.FormatExpression(this, new Expression[] { });
        }

        #endregion
    }
}
