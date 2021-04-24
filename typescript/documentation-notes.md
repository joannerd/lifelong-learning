# Notes

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



[`enum`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#enum
[`any`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#any
[`void`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#void
[`never`]:
    https://www.typescriptlang.org/docs/handbook/basic-types.html#never
