# TypeScript

- [TypeScriptLang.org](https://www.typescriptlang.org/docs/home.html)
- [Do's and Don'ts](https://www.typescriptlang.org/docs/handbook/declaration-files/do-s-and-don-ts.html#general-types)
- [React TypeScript Cheatsheet](https://github.com/typescript-cheatsheets/react-typescript-cheatsheet)
- [TypeScript with React by Paul Halliday](https://alligator.io/react/typescript-with-react/)
- [SmashingMagazine](https://www.smashingmagazine.com/2020/05/typescript-modern-react-projects-webpack-babel/)


## Don't use JS General Types:

- `Number`
- `String`
- `Boolean`
- `Symbol`
- `Object`

## Use TS Basic Types:

- `boolean`
- `number` (decimal `6` / hex `0xf00d` / binary `0b1010` / octal `0o744`)
- `string`
- `number[]` or `Array<number>`
-  tuple
    - Example `let x: [string, number];`
    - Destructuring `let tuple: [number, string, boolean] = [7, "hello", true];`
    - Destructure rest `let [a, ...bc] = tuple; // bc: [string, boolean]`
    - Ignore trailing elements `let [, b] = tuple; // b: string`
- [`enum`]
    ```ts
    enum Color {Red, Green, Blue}
    let r: Color = Color.Red;   // 0
    let g: Color = Color.Green; // 1
    let b: Color = Color.Blue;  // 2
    ```
    ```ts
    enum Color {Red = 1, Green = 3, Blue = 4}
    let r: Color = Color.Red;   // 1
    let g: Color = Color.Green; // 3
    let b: Color = Color.Blue;  // 4
    ```
    ```ts
    enum Color {Red = 1, Green, Blue}
    let r: Color = Color.Red;   // 1
    let g: Color = Color.Green; // 2
    let b: Color = Color.Blue;  // 3
    ```
    ```ts
    enum Color {Red = 1, Green, Blue}
    let colorName: string = Color[2];
    console.log(colorName); // Displays 'Green' as its value is 2 above
    ```
- [`any`]
    ```ts
    let notSure: any = 4;
    notSure = "maybe a string instead";
    notSure = false; // okay, definitely a boolean
    ```
    ```ts
    let list: any[] = [1, true, "free"];
    ```
- [`void`]
    - Assign `null` or `undefined`
        ```ts
        let unusable: void = undefined;
        unusable = null;  // OK if `--strictNullChecks` is not given
        ```
    - Functions that don't return a value
        ```ts
        function warnUser(): void {
            console.log("This is my warning message");
        }
        ```
- `null` / `undefined`
    - Subtypes of all other types
    - Can assign `null` and `undefined` to something like `number`
    - When using the `--strictNullChecks` flag, `null` and `undefined` are only
      assignable to `any` and their respective types
    - Union type `string | null | undefined`
- [`never`]
    - Subtype of and assignable to every type
    - No type is a subtype of or assignable to `never` (except `never` itself)
    - Functions returning `never`
        ```ts
        // Function returning never must have unreachable end point
        function error(message: string): never {
            throw new Error(message);
        }

        // Inferred return type is never
        function fail() {
            return error("Something failed");
        }

        // Function returning never must have unreachable end point
        function infiniteLoop(): never {
            while (true) {
            }
        }
        ```
- `object`
    - Anything that isn't `number`, `string`, `boolean`, `bigint`, `symbol`,
      `null`, or `undefined`

## Type assertions

- Like type cast but w/o special checking/restructuring of data
- TypeScript assumes that programmer has performed the _special checks_ needed
- Angle-bracket syntax
    ```ts
    let val: any = "string";
    let strLength: number = (<string>val).length;
    ```
- `as` syntax **allowed with JSX**
    ```ts
    let val: any = "string";
    let strLength: number = (val as string).length;
    ```

## `tsconfig.json`

```json
{
  "compilerOptions": {
    "jsx": "react",
    "module": "commonjs",
    "noImplicitAny": true,
    "outDir": "./build/",
    "preserveConstEnums": true,
    "removeComments": true,
    "sourceMap": true,
    "target": "es5"
  },
  "include": [
    "src/components/index.tsx"
  ]
}
```

- `compilerOptions` Represents the different compiler options.
- `jsx` Adds support for JSX in .tsx files.
- `module` Generates module code.
- `noImplicitAny` Raises errors for declarations with an implied any type.
- `outDir` Represents the output directory.
- `sourceMap` Generates a .map file, which can be very useful for debugging the
  app.
- `target` Represents the target ECMAScript version to transpile our code down
  to (we can add a version based on our specific browser requirements).
- `include` Used to specify the file list to be included.

## [`webpack.config.js`]

```js
const path = require("path");
const HtmlWebpackPlugin = require("html-webpack-plugin");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
module.exports = {
  entry: "./src/components/index.tsx",
  target: "web",
  mode: "development",
  output: {
    path: path.resolve(\__dirname, "build"),
    filename: "bundle.js",
  },
  resolve: {
    extensions: [".js", ".jsx", ".json", ".ts", ".tsx"],
  },
  module: {
    rules: [
      {
        test: /\.(ts|tsx)$/,
        loader: "awesome-typescript-loader",
      },
      {
        enforce: "pre",
        test: /\.js$/,
        loader: "source-map-loader",
      },
      {
        test: /\.css$/,
        loader: "css-loader",
      },
    ],
  },
  plugins: [
    new HtmlWebpackPlugin({
      template: path.resolve(\__dirname, "src", "components", "index.html"),
    }),
    new MiniCssExtractPlugin({
      filename: "./src/yourfile.css",
    }),
  ],
};
```

- `entry` This specifies the entry point for our app. It may be a single file or
  an array of files that we want to include in our build.
- `output` This contains the output configuration. The app looks at this when
  trying to output bundled code from our project to the disk. The path
  represents the output directory for code to be outputted to, and the file name
  represents the file name for the same. It is generally named bundle.js.
- `resolve` Webpack looks at this attribute to decide whether to bundle or skip
  the file. Thus, in our project, webpack will consider files with the
  extensions `.js, .jsx, .json, .ts , and .tsx` for bundling.
- `module` We can enable webpack to load a particular file when requested by the
  app, using loaders. It takes a `rules` object that specifies that:
    - any file that ends with the extension `.tsx or .ts` should use
      `awesome-typescript-loader` to be loaded;
    - files that end with the `.js` extension should be loaded with
      `source-map-loader`;
    - files that end with the `.css` extension should be loaded with
      `css-loader`.
- `plugins` Webpack has its own limitations, and it provides plugins to overcome
  them and extend its capabilities.
    - `HtmlWebpackPlugin` creates a template file that is rendered to the
      browser from `./src/component/index.html`.
    - `MiniCssExtractPlugin` renders the parent CSS file of the app.


[`enum`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#enum
[`any`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#any
[`void`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#void
[`never`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#never
[`tsconfig.json`]:
    https://www.smashingmagazine.com/2020/05/typescript-modern-react-projects-webpack-babel/#typescript-configuration
[`webpack.config.js`]:
    https://www.smashingmagazine.com/2020/05/typescript-modern-react-projects-webpack-babel/#webpack-configuration
[Generics]:
  https://www.typescriptlang.org/docs/handbook/generics.html
[Lazy Loading]:
  https://blog.logrocket.com/lazy-loading-components-in-react-16-6-6cea535c0b52/
