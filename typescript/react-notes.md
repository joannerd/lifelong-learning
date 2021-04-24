# React Notes

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

## [Generics]


## [Lazy Loading]

[`tsconfig.json`]:
    https://www.smashingmagazine.com/2020/05/typescript-modern-react-projects-webpack-babel/#typescript-configuration
    
[`webpack.config.js`]:
    https://www.smashingmagazine.com/2020/05/typescript-modern-react-projects-webpack-babel/#webpack-configuration

[Generics]:
  https://www.typescriptlang.org/docs/handbook/generics.html

[Lazy Loading]:
  https://blog.logrocket.com/lazy-loading-components-in-react-16-6-6cea535c0b52/