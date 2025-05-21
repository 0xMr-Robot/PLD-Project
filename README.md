# PyLike Language Project

## 🚀 Unleashing the Power of PyLike: A Python-Inspired Language

Welcome to the PyLike project! This endeavor focuses on creating a simple yet powerful programming language inspired by the elegance and readability of Python. Built with a custom grammar and utilizing the robust GOLD Parser, PyLike offers a unique platform for exploring language design and implementation.

This repository houses not only the grammar definition but also a C# Windows Forms application designed to interact with and demonstrate the capabilities of the PyLike language and its parser.

## ✨ Features

*   **Python-Inspired Syntax:** Enjoy a clean and intuitive syntax familiar to Python developers.
*   **Comprehensive Grammar:** A detailed grammar definition for robust parsing.
*   **GOLD Parser Integration:** Leverages the GOLD Parser engine for efficient language processing.
*   **Interactive C# Forms App:** A user-friendly interface to experiment with PyLike code.

## 📜 The PyLike Grammar

The heart of any language is its grammar. The PyLike grammar defines the structure and rules of the language, enabling the GOLD Parser to understand and process PyLike code. Below is the complete grammar definition:

```gold
"Name"    = 'PyLike'
"Author"  = 'Eslam Abbas'
"Version" = '1.0'
"About"   = 'Language like python'

"Case Sensitive" = True
"Start Symbol"   = <Program>

!----------------------------------------------
! Character Sets
!----------------------------------------------
{ID Head}      = {Letter} + [_]
{ID Tail}      = {AlphaNumeric} + [_]
{String Chars} = {Printable} - ["]
{Hex Digit}    = {Digit} + [abcdefABCDEF]
{WS}           = {Whitespace}

!----------------------------------------------
! Terminals
!----------------------------------------------
NewLine        = {CR}{LF} | {CR} | {LF}
Whitespace     = {WS}+

! Comments
CommentLine   = '#' {Printable}* NewLine?

! Literals
IntLiteral    = {Digit}+
HexLiteral    = '0x' {Hex Digit}+
FloatLiteral  = {Digit}+ '.' {Digit}+ | '.' {Digit}+
StringLiteral = '"' {String Chars}* '"'
BoolLiteral   = 'True' | 'False'
NoneLiteral   = 'None'

! Identifiers
Identifier     = {ID Head}{ID Tail}*

!----------------------------------------------
! Rules
!----------------------------------------------

! Program Structure
<Program> ::= <Statements>

<Statements> ::= <Statement> <Statements>
               | <Statement>

<Statement> ::= <SimpleStatement>
              | <CompoundStatement>

<SimpleStatement> ::= <Assignment>
                    | <ExpressionStmt>
                    | <ReturnStmt>
                    | <ImportStmt>
                    | <BreakStmt>
                    | <ContinueStmt>
                    | <PassStmt>

<CompoundStatement> ::= <IfStmt>
                      | <WhileStmt>
                      | <ForStmt>
                      | <FunctionDef>
                      | <ClassDef>

! Basic Statements
<Assignment> ::= <VariableList> '=' <ExpressionList>
               | <PrimaryExpr> '+=' <Expression>
               | <PrimaryExpr> '-=' <Expression>
               | <PrimaryExpr> '*=' <Expression>
               | <PrimaryExpr> '/=' <Expression>
               | <PrimaryExpr> '%=' <Expression>

<VariableList> ::= <PrimaryExpr> ',' <VariableList>
                 | <PrimaryExpr>

! IMPORTANT: Removed <Variable> definition and use <PrimaryExpr> instead

<ExpressionStmt> ::= <Expression>

<ReturnStmt> ::= 'return' <ExpressionList>
               | 'return'

<ImportStmt> ::= 'import' <ModuleList>
               | 'from' <ModuleName> 'import' <IdentifierList>

<ModuleList> ::= <ModuleName> ',' <ModuleList>
               | <ModuleName>

<ModuleName> ::= Identifier
               | <ModuleName> '.' Identifier

<IdentifierList> ::= Identifier ',' <IdentifierList>
                   | Identifier

<BreakStmt> ::= 'break'

<ContinueStmt> ::= 'continue'

<PassStmt> ::= 'pass'

! Control Flow Statements
<IfStmt> ::= 'if' <Expression> ':' <Block> <ElseIfList> <ElseStmt>
           | 'if' <Expression> ':' <Block> <ElseIfList>
           | 'if' <Expression> ':' <Block> <ElseStmt>
           | 'if' <Expression> ':' <Block>

<ElseIfList> ::= 'elif' <Expression> ':' <Block> <ElseIfList>
               | 'elif' <Expression> ':' <Block>

<ElseStmt> ::= 'else' ':' <Block>

<WhileStmt> ::= 'while' <Expression> ':' <Block>

<ForStmt> ::= 'for' <VariableList> 'in' <Expression> ':' <Block>

<Block> ::= <IndentedStatements>

<IndentedStatements> ::= <IndentedStatement> <IndentedStatements>
                       | <IndentedStatement>

<IndentedStatement> ::= <Statement>

! Function Definition
<FunctionDef> ::= 'def' Identifier '(' <ParameterList> ')' ':' <Block>
                | 'def' Identifier '(' ')' ':' <Block>

<ParameterList> ::= <Parameter> ',' <ParameterList>
                  | <Parameter>

<Parameter> ::= Identifier
              | Identifier '=' <Expression>

! Class Definition
<ClassDef> ::= 'class' Identifier '(' <InheritanceList> ')' ':' <Block>
             | 'class' Identifier ':' <Block>

<InheritanceList> ::= <ClassName> ',' <InheritanceList>
                    | <ClassName>

<ClassName> ::= Identifier
              | <ModuleName> '.' Identifier

! Expressions
<ExpressionList> ::= <Expression> ',' <ExpressionList>
                   | <Expression>

<Expression> ::= <OrExpr>

<OrExpr> ::= <AndExpr> 'or' <OrExpr>
           | <AndExpr>

<AndExpr> ::= <NotExpr> 'and' <AndExpr>
            | <NotExpr>

<NotExpr> ::= 'not' <NotExpr>
            | <ComparisonExpr>

<ComparisonExpr> ::= <AdditionExpr> '==' <AdditionExpr>
                   | <AdditionExpr> '!=' <AdditionExpr>
                   | <AdditionExpr> '<' <AdditionExpr>
                   | <AdditionExpr> '<=' <AdditionExpr>
                   | <AdditionExpr> '>' <AdditionExpr>
                   | <AdditionExpr> '>=' <AdditionExpr>
                   | <AdditionExpr> 'in' <AdditionExpr>
                   | <AdditionExpr> 'not' 'in' <AdditionExpr>
                   | <AdditionExpr> 'is' <AdditionExpr>
                   | <AdditionExpr> 'is' 'not' <AdditionExpr>
                   | <AdditionExpr>

<AdditionExpr> ::= <AdditionExpr> '+' <MultiplicationExpr>
                 | <AdditionExpr> '-' <MultiplicationExpr>
                 | <MultiplicationExpr>

<MultiplicationExpr> ::= <MultiplicationExpr> '*' <PowerExpr>
                       | <MultiplicationExpr> '/' <PowerExpr>
                       | <MultiplicationExpr> '//' <PowerExpr>
                       | <MultiplicationExpr> '%' <PowerExpr>
                       | <PowerExpr>

<PowerExpr> ::= <UnaryExpr> '**' <PowerExpr>
              | <UnaryExpr>

<UnaryExpr> ::= '+' <UnaryExpr>
              | '-' <UnaryExpr>
              | <PrimaryExpr>

<PrimaryExpr> ::= <Atom>
                | <PrimaryExpr> '.' Identifier
                | <PrimaryExpr> '[' <Expression> ']'
                | <PrimaryExpr> '(' <ArgumentList> ')'
                | <PrimaryExpr> '(' ')'

<Atom> ::= Identifier
         | IntLiteral
         | FloatLiteral
         | StringLiteral
         | BoolLiteral
         | NoneLiteral
         | '(' <Expression> ')'
         | <ListLiteral>
         | <DictLiteral>

<ArgumentList> ::= <Argument> ',' <ArgumentList>
                 | <Argument>

<Argument> ::= <Expression>
             | Identifier '=' <Expression>

<ListLiteral> ::= '[' <ExpressionList> ']'
                | '[' ']'

<DictLiteral> ::= '{' <KeyValueList> '}'
                | '{' '}'

<KeyValueList> ::= <KeyValue> ',' <KeyValueList>
                 | <KeyValue>

<KeyValue> ::= <Expression> ':' <Expression>

```

## 🛠️ Using the GOLD Parser with PyLike

The GOLD Parser takes the PyLike grammar as input and generates parsing engine files. These files are then used by the C# application to parse and validate PyLike code. This allows for efficient and accurate processing of the language.

## 💻 The C# Forms Application

The C# Windows Forms application provides a user-friendly interface to interact with the PyLike language. You can:

*   Write PyLike code directly in the application.
*   Parse the code using the integrated GOLD Parser engine.
*   Visualize the parsing process (depending on implementation).
*   Potentially execute simple PyLike scripts (depending on implementation).

This application serves as a great tool for testing the grammar, debugging, and showcasing the functionality of the PyLike language.

## 🚀 Getting Started

To get started with the PyLike project:

1.  **Clone the repository:**
    ```bash
    git clone <repository_url> # Replace with your repository URL
    ```
2.  **Build the C# project:** Open the C# solution in Visual Studio (or your preferred C# IDE) and build the project.
3.  **Explore the grammar:** Review the `PyLike.xml` or `PyLike.cgt` file (generated by the GOLD Builder) based on the grammar provided above.
4.  **Run the C# application:** Execute the built C# application.
5.  **Start coding in PyLike!** Use the application to write and test your PyLike code.

## 🤝 Contributing

Contributions are welcome! If you have ideas for improving the PyLike language, grammar, or the C# application, feel free to open an issue or submit a pull request.

## 📄 License

This project is licensed under the [MIT License](LICENSE). # Or other license if applicable

##udos to [Your Name/Contributors] for making this project possible!
