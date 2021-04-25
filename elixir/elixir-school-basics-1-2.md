# Elixir School Basics - 1. Basics

- REPL: `iex`

## Strings

- String concatenation
  ```elixir
  "Hello " <> " Joanna" # "Hello Joanna"
  ```

# Elixir School Basics - 2. Collections

## Lists

- List prepending (fast - O1)
  ```elixir
  list = [3.14, :pie, "Apple"]
  ["π" | list] # ["π", 3.14, :pie, "Apple"]
  ```
- List concatenation/appending (slow - On)
  ```elixir
  list ++ ["Cherry"]
  ```
- List subtractions
  ```elixir
  ["foo", :bar, 42] -- [42, "bar"] # ["foo", :bar]
  [1,2,2,3,2,3] -- [1,2,3,2] # [2, 3]
  [2] -- [2.0] # [2]
  [2.0] -- [2.0] # []
  ```
- Head (`hd` - first element)
  ```elixir
  hd [3.14, :pie, "Apple"] # 3.14
  ```
- Tail (`tl` - remaining elements)
  ```elixir
  tl [3.14, :pie, "Apple"] # [:pie, "Apple"]
  ```
- Pattern matching + cons operator `|`
  ```elixir
  [head | tail] = [3.14, :pie, "Apple"]
  head # 3.14
  tail # [:pie, "Apple"]
  ```

## Tuples

- syntax: `{value, value, value}`
- stored contiguously in memory
  - fast access
  - expensive modification
- often used to return additional information from functions
  ```elixir
  File.read("path/to/existing/file") # {:ok, "... contents ..."}
  File.read("path/to/unknown/file") # {:error, :enoent}
  ```

## Keyword lists

- syntax: `[<atom_key>: <any_value>]`
- keys are **atoms**, **ordered**, and **not-unique**
- share performance with lists
- most commonly used to pass options to functions
  ```elixir
  [foo: "bar", hello: "world"] # [foo: "bar", hello: "world"]
  [{:foo, "bar"}, {:hello, "world"}, {:foo, "hey"}] # [foo: "bar", hello: "world", foo: "hey"]
  ```

## Maps

- syntax: `%{:<any_key> => <any_value>}`
- keys are **any** type and **un-ordered**, and **unique**
- "go-to" key-value store
  ```elixir
  map = %{:foo => "bar", "hello" => :world}
  map[:foo] # "bar"
  map["hello"] # :world
  %{:foo => "bar", :foo => "hello world"} # %{foo: "hello world"}
  ```
- variables can be keys (Elixir 1.2+)
  ```elixir
  key = "hello"
  %{key => "world"} # %{"hello" => "world"}
  ```
- with atom keys
  ```elixir
  map = %{foo: "bar", hello: "world"}
  map == %{:foo => "bar", :hello => "world"} # true (like Ruby hashes with symbols)
  map.hello # "world" (like JavaScript objects)
  ```
- `${map | key: value}` syntax for updates (creates new map)
  ```elixir
  map = %{foo: "bar", hello: "world"}
  %{map | foo: "baz"} # %{foo: "baz", hello: "world"} (`KeyError` will be raised if `foo:` key doesn't exist)
  ```
- `Map.put(map, :atom_key, value)` to create new key
  ```elixir
  map = %{hello: "world"}
  Map.put(map, :foo, "baz") # %{foo: "baz", hello: "world"}
  ```
