
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
            Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

    }

    [Serializable()]
    public class RuleException : System.Exception
    {

        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }

    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF                =   0, // (EOF)
        SYMBOL_ERROR              =   1, // (Error)
        SYMBOL_WHITESPACE         =   2, // Whitespace
        SYMBOL_MINUS              =   3, // '-'
        SYMBOL_EXCLAMEQ           =   4, // '!='
        SYMBOL_PERCENT            =   5, // '%'
        SYMBOL_PERCENTEQ          =   6, // '%='
        SYMBOL_LPAREN             =   7, // '('
        SYMBOL_RPAREN             =   8, // ')'
        SYMBOL_TIMES              =   9, // '*'
        SYMBOL_TIMESTIMES         =  10, // '**'
        SYMBOL_TIMESEQ            =  11, // '*='
        SYMBOL_COMMA              =  12, // ','
        SYMBOL_DOT                =  13, // '.'
        SYMBOL_DIV                =  14, // '/'
        SYMBOL_DIVDIV             =  15, // '//'
        SYMBOL_DIVEQ              =  16, // '/='
        SYMBOL_COLON              =  17, // ':'
        SYMBOL_LBRACKET           =  18, // '['
        SYMBOL_RBRACKET           =  19, // ']'
        SYMBOL_LBRACE             =  20, // '{'
        SYMBOL_RBRACE             =  21, // '}'
        SYMBOL_PLUS               =  22, // '+'
        SYMBOL_PLUSEQ             =  23, // '+='
        SYMBOL_LT                 =  24, // '<'
        SYMBOL_LTEQ               =  25, // '<='
        SYMBOL_EQ                 =  26, // '='
        SYMBOL_MINUSEQ            =  27, // '-='
        SYMBOL_EQEQ               =  28, // '=='
        SYMBOL_GT                 =  29, // '>'
        SYMBOL_GTEQ               =  30, // '>='
        SYMBOL_AND                =  31, // and
        SYMBOL_BOOLLITERAL        =  32, // BoolLiteral
        SYMBOL_BREAK              =  33, // break
        SYMBOL_CLASS              =  34, // class
        SYMBOL_COMMENTLINE        =  35, // CommentLine
        SYMBOL_CONTINUE           =  36, // continue
        SYMBOL_DEF                =  37, // def
        SYMBOL_ELIF               =  38, // elif
        SYMBOL_ELSE               =  39, // else
        SYMBOL_FLOATLITERAL       =  40, // FloatLiteral
        SYMBOL_FOR                =  41, // for
        SYMBOL_FROM               =  42, // from
        SYMBOL_HEXLITERAL         =  43, // HexLiteral
        SYMBOL_IDENTIFIER         =  44, // Identifier
        SYMBOL_IF                 =  45, // if
        SYMBOL_IMPORT             =  46, // import
        SYMBOL_IN                 =  47, // in
        SYMBOL_INTLITERAL         =  48, // IntLiteral
        SYMBOL_IS                 =  49, // is
        SYMBOL_NEWLINE            =  50, // NewLine
        SYMBOL_NONELITERAL        =  51, // NoneLiteral
        SYMBOL_NOT                =  52, // not
        SYMBOL_OR                 =  53, // or
        SYMBOL_PASS               =  54, // pass
        SYMBOL_RETURN             =  55, // return
        SYMBOL_STRINGLITERAL      =  56, // StringLiteral
        SYMBOL_WHILE              =  57, // while
        SYMBOL_ADDITIONEXPR       =  58, // <AdditionExpr>
        SYMBOL_ANDEXPR            =  59, // <AndExpr>
        SYMBOL_ARGUMENT           =  60, // <Argument>
        SYMBOL_ARGUMENTLIST       =  61, // <ArgumentList>
        SYMBOL_ASSIGNMENT         =  62, // <Assignment>
        SYMBOL_ATOM               =  63, // <Atom>
        SYMBOL_BLOCK              =  64, // <Block>
        SYMBOL_BREAKSTMT          =  65, // <BreakStmt>
        SYMBOL_CLASSDEF           =  66, // <ClassDef>
        SYMBOL_CLASSNAME          =  67, // <ClassName>
        SYMBOL_COMPARISONEXPR     =  68, // <ComparisonExpr>
        SYMBOL_COMPOUNDSTATEMENT  =  69, // <CompoundStatement>
        SYMBOL_CONTINUESTMT       =  70, // <ContinueStmt>
        SYMBOL_DICTLITERAL        =  71, // <DictLiteral>
        SYMBOL_ELSEIFLIST         =  72, // <ElseIfList>
        SYMBOL_ELSESTMT           =  73, // <ElseStmt>
        SYMBOL_EXPRESSION         =  74, // <Expression>
        SYMBOL_EXPRESSIONLIST     =  75, // <ExpressionList>
        SYMBOL_EXPRESSIONSTMT     =  76, // <ExpressionStmt>
        SYMBOL_FORSTMT            =  77, // <ForStmt>
        SYMBOL_FUNCTIONDEF        =  78, // <FunctionDef>
        SYMBOL_IDENTIFIERLIST     =  79, // <IdentifierList>
        SYMBOL_IFSTMT             =  80, // <IfStmt>
        SYMBOL_IMPORTSTMT         =  81, // <ImportStmt>
        SYMBOL_INDENTEDSTATEMENT  =  82, // <IndentedStatement>
        SYMBOL_INDENTEDSTATEMENTS =  83, // <IndentedStatements>
        SYMBOL_INHERITANCELIST    =  84, // <InheritanceList>
        SYMBOL_KEYVALUE           =  85, // <KeyValue>
        SYMBOL_KEYVALUELIST       =  86, // <KeyValueList>
        SYMBOL_LISTLITERAL        =  87, // <ListLiteral>
        SYMBOL_MODULELIST         =  88, // <ModuleList>
        SYMBOL_MODULENAME         =  89, // <ModuleName>
        SYMBOL_MULTIPLICATIONEXPR =  90, // <MultiplicationExpr>
        SYMBOL_NOTEXPR            =  91, // <NotExpr>
        SYMBOL_OREXPR             =  92, // <OrExpr>
        SYMBOL_PARAMETER          =  93, // <Parameter>
        SYMBOL_PARAMETERLIST      =  94, // <ParameterList>
        SYMBOL_PASSSTMT           =  95, // <PassStmt>
        SYMBOL_POWEREXPR          =  96, // <PowerExpr>
        SYMBOL_PRIMARYEXPR        =  97, // <PrimaryExpr>
        SYMBOL_PROGRAM            =  98, // <Program>
        SYMBOL_RETURNSTMT         =  99, // <ReturnStmt>
        SYMBOL_SIMPLESTATEMENT    = 100, // <SimpleStatement>
        SYMBOL_STATEMENT          = 101, // <Statement>
        SYMBOL_STATEMENTS         = 102, // <Statements>
        SYMBOL_UNARYEXPR          = 103, // <UnaryExpr>
        SYMBOL_VARIABLELIST       = 104, // <VariableList>
        SYMBOL_WHILESTMT          = 105  // <WhileStmt>
    };

    enum RuleConstants : int
    {
        RULE_PROGRAM                                         =   0, // <Program> ::= <Statements>
        RULE_STATEMENTS                                      =   1, // <Statements> ::= <Statement> <Statements>
        RULE_STATEMENTS2                                     =   2, // <Statements> ::= <Statement>
        RULE_STATEMENT                                       =   3, // <Statement> ::= <SimpleStatement>
        RULE_STATEMENT2                                      =   4, // <Statement> ::= <CompoundStatement>
        RULE_SIMPLESTATEMENT                                 =   5, // <SimpleStatement> ::= <Assignment>
        RULE_SIMPLESTATEMENT2                                =   6, // <SimpleStatement> ::= <ExpressionStmt>
        RULE_SIMPLESTATEMENT3                                =   7, // <SimpleStatement> ::= <ReturnStmt>
        RULE_SIMPLESTATEMENT4                                =   8, // <SimpleStatement> ::= <ImportStmt>
        RULE_SIMPLESTATEMENT5                                =   9, // <SimpleStatement> ::= <BreakStmt>
        RULE_SIMPLESTATEMENT6                                =  10, // <SimpleStatement> ::= <ContinueStmt>
        RULE_SIMPLESTATEMENT7                                =  11, // <SimpleStatement> ::= <PassStmt>
        RULE_COMPOUNDSTATEMENT                               =  12, // <CompoundStatement> ::= <IfStmt>
        RULE_COMPOUNDSTATEMENT2                              =  13, // <CompoundStatement> ::= <WhileStmt>
        RULE_COMPOUNDSTATEMENT3                              =  14, // <CompoundStatement> ::= <ForStmt>
        RULE_COMPOUNDSTATEMENT4                              =  15, // <CompoundStatement> ::= <FunctionDef>
        RULE_COMPOUNDSTATEMENT5                              =  16, // <CompoundStatement> ::= <ClassDef>
        RULE_ASSIGNMENT_EQ                                   =  17, // <Assignment> ::= <VariableList> '=' <ExpressionList>
        RULE_ASSIGNMENT_PLUSEQ                               =  18, // <Assignment> ::= <PrimaryExpr> '+=' <Expression>
        RULE_ASSIGNMENT_MINUSEQ                              =  19, // <Assignment> ::= <PrimaryExpr> '-=' <Expression>
        RULE_ASSIGNMENT_TIMESEQ                              =  20, // <Assignment> ::= <PrimaryExpr> '*=' <Expression>
        RULE_ASSIGNMENT_DIVEQ                                =  21, // <Assignment> ::= <PrimaryExpr> '/=' <Expression>
        RULE_ASSIGNMENT_PERCENTEQ                            =  22, // <Assignment> ::= <PrimaryExpr> '%=' <Expression>
        RULE_VARIABLELIST_COMMA                              =  23, // <VariableList> ::= <PrimaryExpr> ',' <VariableList>
        RULE_VARIABLELIST                                    =  24, // <VariableList> ::= <PrimaryExpr>
        RULE_EXPRESSIONSTMT                                  =  25, // <ExpressionStmt> ::= <Expression>
        RULE_RETURNSTMT_RETURN                               =  26, // <ReturnStmt> ::= return <ExpressionList>
        RULE_RETURNSTMT_RETURN2                              =  27, // <ReturnStmt> ::= return
        RULE_IMPORTSTMT_IMPORT                               =  28, // <ImportStmt> ::= import <ModuleList>
        RULE_IMPORTSTMT_FROM_IMPORT                          =  29, // <ImportStmt> ::= from <ModuleName> import <IdentifierList>
        RULE_MODULELIST_COMMA                                =  30, // <ModuleList> ::= <ModuleName> ',' <ModuleList>
        RULE_MODULELIST                                      =  31, // <ModuleList> ::= <ModuleName>
        RULE_MODULENAME_IDENTIFIER                           =  32, // <ModuleName> ::= Identifier
        RULE_MODULENAME_DOT_IDENTIFIER                       =  33, // <ModuleName> ::= <ModuleName> '.' Identifier
        RULE_IDENTIFIERLIST_IDENTIFIER_COMMA                 =  34, // <IdentifierList> ::= Identifier ',' <IdentifierList>
        RULE_IDENTIFIERLIST_IDENTIFIER                       =  35, // <IdentifierList> ::= Identifier
        RULE_BREAKSTMT_BREAK                                 =  36, // <BreakStmt> ::= break
        RULE_CONTINUESTMT_CONTINUE                           =  37, // <ContinueStmt> ::= continue
        RULE_PASSSTMT_PASS                                   =  38, // <PassStmt> ::= pass
        RULE_IFSTMT_IF_COLON                                 =  39, // <IfStmt> ::= if <Expression> ':' <Block> <ElseIfList> <ElseStmt>
        RULE_IFSTMT_IF_COLON2                                =  40, // <IfStmt> ::= if <Expression> ':' <Block> <ElseIfList>
        RULE_IFSTMT_IF_COLON3                                =  41, // <IfStmt> ::= if <Expression> ':' <Block> <ElseStmt>
        RULE_IFSTMT_IF_COLON4                                =  42, // <IfStmt> ::= if <Expression> ':' <Block>
        RULE_ELSEIFLIST_ELIF_COLON                           =  43, // <ElseIfList> ::= elif <Expression> ':' <Block> <ElseIfList>
        RULE_ELSEIFLIST_ELIF_COLON2                          =  44, // <ElseIfList> ::= elif <Expression> ':' <Block>
        RULE_ELSESTMT_ELSE_COLON                             =  45, // <ElseStmt> ::= else ':' <Block>
        RULE_WHILESTMT_WHILE_COLON                           =  46, // <WhileStmt> ::= while <Expression> ':' <Block>
        RULE_FORSTMT_FOR_IN_COLON                            =  47, // <ForStmt> ::= for <VariableList> in <Expression> ':' <Block>
        RULE_BLOCK                                           =  48, // <Block> ::= <IndentedStatements>
        RULE_INDENTEDSTATEMENTS                              =  49, // <IndentedStatements> ::= <IndentedStatement> <IndentedStatements>
        RULE_INDENTEDSTATEMENTS2                             =  50, // <IndentedStatements> ::= <IndentedStatement>
        RULE_INDENTEDSTATEMENT                               =  51, // <IndentedStatement> ::= <Statement>
        RULE_FUNCTIONDEF_DEF_IDENTIFIER_LPAREN_RPAREN_COLON  =  52, // <FunctionDef> ::= def Identifier '(' <ParameterList> ')' ':' <Block>
        RULE_FUNCTIONDEF_DEF_IDENTIFIER_LPAREN_RPAREN_COLON2 =  53, // <FunctionDef> ::= def Identifier '(' ')' ':' <Block>
        RULE_PARAMETERLIST_COMMA                             =  54, // <ParameterList> ::= <Parameter> ',' <ParameterList>
        RULE_PARAMETERLIST                                   =  55, // <ParameterList> ::= <Parameter>
        RULE_PARAMETER_IDENTIFIER                            =  56, // <Parameter> ::= Identifier
        RULE_PARAMETER_IDENTIFIER_EQ                         =  57, // <Parameter> ::= Identifier '=' <Expression>
        RULE_CLASSDEF_CLASS_IDENTIFIER_LPAREN_RPAREN_COLON   =  58, // <ClassDef> ::= class Identifier '(' <InheritanceList> ')' ':' <Block>
        RULE_CLASSDEF_CLASS_IDENTIFIER_COLON                 =  59, // <ClassDef> ::= class Identifier ':' <Block>
        RULE_INHERITANCELIST_COMMA                           =  60, // <InheritanceList> ::= <ClassName> ',' <InheritanceList>
        RULE_INHERITANCELIST                                 =  61, // <InheritanceList> ::= <ClassName>
        RULE_CLASSNAME_IDENTIFIER                            =  62, // <ClassName> ::= Identifier
        RULE_CLASSNAME_DOT_IDENTIFIER                        =  63, // <ClassName> ::= <ModuleName> '.' Identifier
        RULE_EXPRESSIONLIST_COMMA                            =  64, // <ExpressionList> ::= <Expression> ',' <ExpressionList>
        RULE_EXPRESSIONLIST                                  =  65, // <ExpressionList> ::= <Expression>
        RULE_EXPRESSION                                      =  66, // <Expression> ::= <OrExpr>
        RULE_OREXPR_OR                                       =  67, // <OrExpr> ::= <AndExpr> or <OrExpr>
        RULE_OREXPR                                          =  68, // <OrExpr> ::= <AndExpr>
        RULE_ANDEXPR_AND                                     =  69, // <AndExpr> ::= <NotExpr> and <AndExpr>
        RULE_ANDEXPR                                         =  70, // <AndExpr> ::= <NotExpr>
        RULE_NOTEXPR_NOT                                     =  71, // <NotExpr> ::= not <NotExpr>
        RULE_NOTEXPR                                         =  72, // <NotExpr> ::= <ComparisonExpr>
        RULE_COMPARISONEXPR_EQEQ                             =  73, // <ComparisonExpr> ::= <AdditionExpr> '==' <AdditionExpr>
        RULE_COMPARISONEXPR_EXCLAMEQ                         =  74, // <ComparisonExpr> ::= <AdditionExpr> '!=' <AdditionExpr>
        RULE_COMPARISONEXPR_LT                               =  75, // <ComparisonExpr> ::= <AdditionExpr> '<' <AdditionExpr>
        RULE_COMPARISONEXPR_LTEQ                             =  76, // <ComparisonExpr> ::= <AdditionExpr> '<=' <AdditionExpr>
        RULE_COMPARISONEXPR_GT                               =  77, // <ComparisonExpr> ::= <AdditionExpr> '>' <AdditionExpr>
        RULE_COMPARISONEXPR_GTEQ                             =  78, // <ComparisonExpr> ::= <AdditionExpr> '>=' <AdditionExpr>
        RULE_COMPARISONEXPR_IN                               =  79, // <ComparisonExpr> ::= <AdditionExpr> in <AdditionExpr>
        RULE_COMPARISONEXPR_NOT_IN                           =  80, // <ComparisonExpr> ::= <AdditionExpr> not in <AdditionExpr>
        RULE_COMPARISONEXPR_IS                               =  81, // <ComparisonExpr> ::= <AdditionExpr> is <AdditionExpr>
        RULE_COMPARISONEXPR_IS_NOT                           =  82, // <ComparisonExpr> ::= <AdditionExpr> is not <AdditionExpr>
        RULE_COMPARISONEXPR                                  =  83, // <ComparisonExpr> ::= <AdditionExpr>
        RULE_ADDITIONEXPR_PLUS                               =  84, // <AdditionExpr> ::= <AdditionExpr> '+' <MultiplicationExpr>
        RULE_ADDITIONEXPR_MINUS                              =  85, // <AdditionExpr> ::= <AdditionExpr> '-' <MultiplicationExpr>
        RULE_ADDITIONEXPR                                    =  86, // <AdditionExpr> ::= <MultiplicationExpr>
        RULE_MULTIPLICATIONEXPR_TIMES                        =  87, // <MultiplicationExpr> ::= <MultiplicationExpr> '*' <PowerExpr>
        RULE_MULTIPLICATIONEXPR_DIV                          =  88, // <MultiplicationExpr> ::= <MultiplicationExpr> '/' <PowerExpr>
        RULE_MULTIPLICATIONEXPR_DIVDIV                       =  89, // <MultiplicationExpr> ::= <MultiplicationExpr> '//' <PowerExpr>
        RULE_MULTIPLICATIONEXPR_PERCENT                      =  90, // <MultiplicationExpr> ::= <MultiplicationExpr> '%' <PowerExpr>
        RULE_MULTIPLICATIONEXPR                              =  91, // <MultiplicationExpr> ::= <PowerExpr>
        RULE_POWEREXPR_TIMESTIMES                            =  92, // <PowerExpr> ::= <UnaryExpr> '**' <PowerExpr>
        RULE_POWEREXPR                                       =  93, // <PowerExpr> ::= <UnaryExpr>
        RULE_UNARYEXPR_PLUS                                  =  94, // <UnaryExpr> ::= '+' <UnaryExpr>
        RULE_UNARYEXPR_MINUS                                 =  95, // <UnaryExpr> ::= '-' <UnaryExpr>
        RULE_UNARYEXPR                                       =  96, // <UnaryExpr> ::= <PrimaryExpr>
        RULE_PRIMARYEXPR                                     =  97, // <PrimaryExpr> ::= <Atom>
        RULE_PRIMARYEXPR_DOT_IDENTIFIER                      =  98, // <PrimaryExpr> ::= <PrimaryExpr> '.' Identifier
        RULE_PRIMARYEXPR_LBRACKET_RBRACKET                   =  99, // <PrimaryExpr> ::= <PrimaryExpr> '[' <Expression> ']'
        RULE_PRIMARYEXPR_LPAREN_RPAREN                       = 100, // <PrimaryExpr> ::= <PrimaryExpr> '(' <ArgumentList> ')'
        RULE_PRIMARYEXPR_LPAREN_RPAREN2                      = 101, // <PrimaryExpr> ::= <PrimaryExpr> '(' ')'
        RULE_ATOM_IDENTIFIER                                 = 102, // <Atom> ::= Identifier
        RULE_ATOM_INTLITERAL                                 = 103, // <Atom> ::= IntLiteral
        RULE_ATOM_FLOATLITERAL                               = 104, // <Atom> ::= FloatLiteral
        RULE_ATOM_STRINGLITERAL                              = 105, // <Atom> ::= StringLiteral
        RULE_ATOM_BOOLLITERAL                                = 106, // <Atom> ::= BoolLiteral
        RULE_ATOM_NONELITERAL                                = 107, // <Atom> ::= NoneLiteral
        RULE_ATOM_LPAREN_RPAREN                              = 108, // <Atom> ::= '(' <Expression> ')'
        RULE_ATOM                                            = 109, // <Atom> ::= <ListLiteral>
        RULE_ATOM2                                           = 110, // <Atom> ::= <DictLiteral>
        RULE_ARGUMENTLIST_COMMA                              = 111, // <ArgumentList> ::= <Argument> ',' <ArgumentList>
        RULE_ARGUMENTLIST                                    = 112, // <ArgumentList> ::= <Argument>
        RULE_ARGUMENT                                        = 113, // <Argument> ::= <Expression>
        RULE_ARGUMENT_IDENTIFIER_EQ                          = 114, // <Argument> ::= Identifier '=' <Expression>
        RULE_LISTLITERAL_LBRACKET_RBRACKET                   = 115, // <ListLiteral> ::= '[' <ExpressionList> ']'
        RULE_LISTLITERAL_LBRACKET_RBRACKET2                  = 116, // <ListLiteral> ::= '[' ']'
        RULE_DICTLITERAL_LBRACE_RBRACE                       = 117, // <DictLiteral> ::= '{' <KeyValueList> '}'
        RULE_DICTLITERAL_LBRACE_RBRACE2                      = 118, // <DictLiteral> ::= '{' '}'
        RULE_KEYVALUELIST_COMMA                              = 119, // <KeyValueList> ::= <KeyValue> ',' <KeyValueList>
        RULE_KEYVALUELIST                                    = 120, // <KeyValueList> ::= <KeyValue>
        RULE_KEYVALUE_COLON                                  = 121  // <KeyValue> ::= <Expression> ':' <Expression>
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //'!='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENT :
                //'%'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENTEQ :
                //'%='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMESTIMES :
                //'**'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMESEQ :
                //'*='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DOT :
                //'.'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIVDIV :
                //'//'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIVEQ :
                //'/='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACKET :
                //'['
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACKET :
                //']'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //'{'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //'}'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUSEQ :
                //'+='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                //'<='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUSEQ :
                //'-='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //'=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                //'>='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AND :
                //and
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BOOLLITERAL :
                //BoolLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BREAK :
                //break
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CLASS :
                //class
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENTLINE :
                //CommentLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONTINUE :
                //continue
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DEF :
                //def
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELIF :
                //elif
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSE :
                //else
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FLOATLITERAL :
                //FloatLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR :
                //for
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FROM :
                //from
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_HEXLITERAL :
                //HexLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIER :
                //Identifier
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF :
                //if
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IMPORT :
                //import
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IN :
                //in
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INTLITERAL :
                //IntLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IS :
                //is
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                //NewLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NONELITERAL :
                //NoneLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NOT :
                //not
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OR :
                //or
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PASS :
                //pass
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RETURN :
                //return
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STRINGLITERAL :
                //StringLiteral
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE :
                //while
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ADDITIONEXPR :
                //<AdditionExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ANDEXPR :
                //<AndExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARGUMENT :
                //<Argument>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ARGUMENTLIST :
                //<ArgumentList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGNMENT :
                //<Assignment>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ATOM :
                //<Atom>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BLOCK :
                //<Block>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BREAKSTMT :
                //<BreakStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CLASSDEF :
                //<ClassDef>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CLASSNAME :
                //<ClassName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMPARISONEXPR :
                //<ComparisonExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMPOUNDSTATEMENT :
                //<CompoundStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONTINUESTMT :
                //<ContinueStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DICTLITERAL :
                //<DictLiteral>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSEIFLIST :
                //<ElseIfList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSESTMT :
                //<ElseStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSIONLIST :
                //<ExpressionList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSIONSTMT :
                //<ExpressionStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FORSTMT :
                //<ForStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FUNCTIONDEF :
                //<FunctionDef>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IDENTIFIERLIST :
                //<IdentifierList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IFSTMT :
                //<IfStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IMPORTSTMT :
                //<ImportStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INDENTEDSTATEMENT :
                //<IndentedStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INDENTEDSTATEMENTS :
                //<IndentedStatements>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INHERITANCELIST :
                //<InheritanceList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYVALUE :
                //<KeyValue>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_KEYVALUELIST :
                //<KeyValueList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LISTLITERAL :
                //<ListLiteral>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MODULELIST :
                //<ModuleList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MODULENAME :
                //<ModuleName>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MULTIPLICATIONEXPR :
                //<MultiplicationExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NOTEXPR :
                //<NotExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OREXPR :
                //<OrExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PARAMETER :
                //<Parameter>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PARAMETERLIST :
                //<ParameterList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PASSSTMT :
                //<PassStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_POWEREXPR :
                //<PowerExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRIMARYEXPR :
                //<PrimaryExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PROGRAM :
                //<Program>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RETURNSTMT :
                //<ReturnStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SIMPLESTATEMENT :
                //<SimpleStatement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENT :
                //<Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENTS :
                //<Statements>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_UNARYEXPR :
                //<UnaryExpr>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VARIABLELIST :
                //<VariableList>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILESTMT :
                //<WhileStmt>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_PROGRAM :
                //<Program> ::= <Statements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTS :
                //<Statements> ::= <Statement> <Statements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTS2 :
                //<Statements> ::= <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT :
                //<Statement> ::= <SimpleStatement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT2 :
                //<Statement> ::= <CompoundStatement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT :
                //<SimpleStatement> ::= <Assignment>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT2 :
                //<SimpleStatement> ::= <ExpressionStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT3 :
                //<SimpleStatement> ::= <ReturnStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT4 :
                //<SimpleStatement> ::= <ImportStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT5 :
                //<SimpleStatement> ::= <BreakStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT6 :
                //<SimpleStatement> ::= <ContinueStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SIMPLESTATEMENT7 :
                //<SimpleStatement> ::= <PassStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPOUNDSTATEMENT :
                //<CompoundStatement> ::= <IfStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPOUNDSTATEMENT2 :
                //<CompoundStatement> ::= <WhileStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPOUNDSTATEMENT3 :
                //<CompoundStatement> ::= <ForStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPOUNDSTATEMENT4 :
                //<CompoundStatement> ::= <FunctionDef>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPOUNDSTATEMENT5 :
                //<CompoundStatement> ::= <ClassDef>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_EQ :
                //<Assignment> ::= <VariableList> '=' <ExpressionList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_PLUSEQ :
                //<Assignment> ::= <PrimaryExpr> '+=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_MINUSEQ :
                //<Assignment> ::= <PrimaryExpr> '-=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_TIMESEQ :
                //<Assignment> ::= <PrimaryExpr> '*=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_DIVEQ :
                //<Assignment> ::= <PrimaryExpr> '/=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGNMENT_PERCENTEQ :
                //<Assignment> ::= <PrimaryExpr> '%=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLELIST_COMMA :
                //<VariableList> ::= <PrimaryExpr> ',' <VariableList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VARIABLELIST :
                //<VariableList> ::= <PrimaryExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONSTMT :
                //<ExpressionStmt> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RETURNSTMT_RETURN :
                //<ReturnStmt> ::= return <ExpressionList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_RETURNSTMT_RETURN2 :
                //<ReturnStmt> ::= return
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IMPORTSTMT_IMPORT :
                //<ImportStmt> ::= import <ModuleList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IMPORTSTMT_FROM_IMPORT :
                //<ImportStmt> ::= from <ModuleName> import <IdentifierList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODULELIST_COMMA :
                //<ModuleList> ::= <ModuleName> ',' <ModuleList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODULELIST :
                //<ModuleList> ::= <ModuleName>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODULENAME_IDENTIFIER :
                //<ModuleName> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODULENAME_DOT_IDENTIFIER :
                //<ModuleName> ::= <ModuleName> '.' Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IDENTIFIERLIST_IDENTIFIER_COMMA :
                //<IdentifierList> ::= Identifier ',' <IdentifierList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IDENTIFIERLIST_IDENTIFIER :
                //<IdentifierList> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BREAKSTMT_BREAK :
                //<BreakStmt> ::= break
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONTINUESTMT_CONTINUE :
                //<ContinueStmt> ::= continue
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PASSSTMT_PASS :
                //<PassStmt> ::= pass
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTMT_IF_COLON :
                //<IfStmt> ::= if <Expression> ':' <Block> <ElseIfList> <ElseStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTMT_IF_COLON2 :
                //<IfStmt> ::= if <Expression> ':' <Block> <ElseIfList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTMT_IF_COLON3 :
                //<IfStmt> ::= if <Expression> ':' <Block> <ElseStmt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IFSTMT_IF_COLON4 :
                //<IfStmt> ::= if <Expression> ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ELSEIFLIST_ELIF_COLON :
                //<ElseIfList> ::= elif <Expression> ':' <Block> <ElseIfList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ELSEIFLIST_ELIF_COLON2 :
                //<ElseIfList> ::= elif <Expression> ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ELSESTMT_ELSE_COLON :
                //<ElseStmt> ::= else ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_WHILESTMT_WHILE_COLON :
                //<WhileStmt> ::= while <Expression> ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FORSTMT_FOR_IN_COLON :
                //<ForStmt> ::= for <VariableList> in <Expression> ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BLOCK :
                //<Block> ::= <IndentedStatements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INDENTEDSTATEMENTS :
                //<IndentedStatements> ::= <IndentedStatement> <IndentedStatements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INDENTEDSTATEMENTS2 :
                //<IndentedStatements> ::= <IndentedStatement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INDENTEDSTATEMENT :
                //<IndentedStatement> ::= <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNCTIONDEF_DEF_IDENTIFIER_LPAREN_RPAREN_COLON :
                //<FunctionDef> ::= def Identifier '(' <ParameterList> ')' ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FUNCTIONDEF_DEF_IDENTIFIER_LPAREN_RPAREN_COLON2 :
                //<FunctionDef> ::= def Identifier '(' ')' ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETERLIST_COMMA :
                //<ParameterList> ::= <Parameter> ',' <ParameterList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETERLIST :
                //<ParameterList> ::= <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER_IDENTIFIER :
                //<Parameter> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER_IDENTIFIER_EQ :
                //<Parameter> ::= Identifier '=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CLASSDEF_CLASS_IDENTIFIER_LPAREN_RPAREN_COLON :
                //<ClassDef> ::= class Identifier '(' <InheritanceList> ')' ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CLASSDEF_CLASS_IDENTIFIER_COLON :
                //<ClassDef> ::= class Identifier ':' <Block>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INHERITANCELIST_COMMA :
                //<InheritanceList> ::= <ClassName> ',' <InheritanceList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_INHERITANCELIST :
                //<InheritanceList> ::= <ClassName>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CLASSNAME_IDENTIFIER :
                //<ClassName> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CLASSNAME_DOT_IDENTIFIER :
                //<ClassName> ::= <ModuleName> '.' Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONLIST_COMMA :
                //<ExpressionList> ::= <Expression> ',' <ExpressionList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONLIST :
                //<ExpressionList> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <OrExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OREXPR_OR :
                //<OrExpr> ::= <AndExpr> or <OrExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OREXPR :
                //<OrExpr> ::= <AndExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ANDEXPR_AND :
                //<AndExpr> ::= <NotExpr> and <AndExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ANDEXPR :
                //<AndExpr> ::= <NotExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NOTEXPR_NOT :
                //<NotExpr> ::= not <NotExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NOTEXPR :
                //<NotExpr> ::= <ComparisonExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_EQEQ :
                //<ComparisonExpr> ::= <AdditionExpr> '==' <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_EXCLAMEQ :
                //<ComparisonExpr> ::= <AdditionExpr> '!=' <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_LT :
                //<ComparisonExpr> ::= <AdditionExpr> '<' <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_LTEQ :
                //<ComparisonExpr> ::= <AdditionExpr> '<=' <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_GT :
                //<ComparisonExpr> ::= <AdditionExpr> '>' <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_GTEQ :
                //<ComparisonExpr> ::= <AdditionExpr> '>=' <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_IN :
                //<ComparisonExpr> ::= <AdditionExpr> in <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_NOT_IN :
                //<ComparisonExpr> ::= <AdditionExpr> not in <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_IS :
                //<ComparisonExpr> ::= <AdditionExpr> is <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR_IS_NOT :
                //<ComparisonExpr> ::= <AdditionExpr> is not <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPARISONEXPR :
                //<ComparisonExpr> ::= <AdditionExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIONEXPR_PLUS :
                //<AdditionExpr> ::= <AdditionExpr> '+' <MultiplicationExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIONEXPR_MINUS :
                //<AdditionExpr> ::= <AdditionExpr> '-' <MultiplicationExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDITIONEXPR :
                //<AdditionExpr> ::= <MultiplicationExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIONEXPR_TIMES :
                //<MultiplicationExpr> ::= <MultiplicationExpr> '*' <PowerExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIONEXPR_DIV :
                //<MultiplicationExpr> ::= <MultiplicationExpr> '/' <PowerExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIONEXPR_DIVDIV :
                //<MultiplicationExpr> ::= <MultiplicationExpr> '//' <PowerExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIONEXPR_PERCENT :
                //<MultiplicationExpr> ::= <MultiplicationExpr> '%' <PowerExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTIPLICATIONEXPR :
                //<MultiplicationExpr> ::= <PowerExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_POWEREXPR_TIMESTIMES :
                //<PowerExpr> ::= <UnaryExpr> '**' <PowerExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_POWEREXPR :
                //<PowerExpr> ::= <UnaryExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYEXPR_PLUS :
                //<UnaryExpr> ::= '+' <UnaryExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYEXPR_MINUS :
                //<UnaryExpr> ::= '-' <UnaryExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_UNARYEXPR :
                //<UnaryExpr> ::= <PrimaryExpr>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMARYEXPR :
                //<PrimaryExpr> ::= <Atom>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMARYEXPR_DOT_IDENTIFIER :
                //<PrimaryExpr> ::= <PrimaryExpr> '.' Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMARYEXPR_LBRACKET_RBRACKET :
                //<PrimaryExpr> ::= <PrimaryExpr> '[' <Expression> ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMARYEXPR_LPAREN_RPAREN :
                //<PrimaryExpr> ::= <PrimaryExpr> '(' <ArgumentList> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRIMARYEXPR_LPAREN_RPAREN2 :
                //<PrimaryExpr> ::= <PrimaryExpr> '(' ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_IDENTIFIER :
                //<Atom> ::= Identifier
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_INTLITERAL :
                //<Atom> ::= IntLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_FLOATLITERAL :
                //<Atom> ::= FloatLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_STRINGLITERAL :
                //<Atom> ::= StringLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_BOOLLITERAL :
                //<Atom> ::= BoolLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_NONELITERAL :
                //<Atom> ::= NoneLiteral
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM_LPAREN_RPAREN :
                //<Atom> ::= '(' <Expression> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM :
                //<Atom> ::= <ListLiteral>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ATOM2 :
                //<Atom> ::= <DictLiteral>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARGUMENTLIST_COMMA :
                //<ArgumentList> ::= <Argument> ',' <ArgumentList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARGUMENTLIST :
                //<ArgumentList> ::= <Argument>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARGUMENT :
                //<Argument> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ARGUMENT_IDENTIFIER_EQ :
                //<Argument> ::= Identifier '=' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LISTLITERAL_LBRACKET_RBRACKET :
                //<ListLiteral> ::= '[' <ExpressionList> ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LISTLITERAL_LBRACKET_RBRACKET2 :
                //<ListLiteral> ::= '[' ']'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_DICTLITERAL_LBRACE_RBRACE :
                //<DictLiteral> ::= '{' <KeyValueList> '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_DICTLITERAL_LBRACE_RBRACE2 :
                //<DictLiteral> ::= '{' '}'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_KEYVALUELIST_COMMA :
                //<KeyValueList> ::= <KeyValue> ',' <KeyValueList>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_KEYVALUELIST :
                //<KeyValueList> ::= <KeyValue>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_KEYVALUE_COLON :
                //<KeyValue> ::= <Expression> ':' <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            //todo: Report message to UI?
        }

    }
}
