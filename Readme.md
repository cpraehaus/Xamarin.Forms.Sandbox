# Xamarin.Forms Sandbox

Test project for experiments with Xamarin.Forms or for reproduction of bugs.

Based on https://github.com/PureWeen/Xamarin.Forms.Sandbox (thanks to PureWeen).

# Xamarin.Forms

Which Xamarin.Forms version to use is configured in ``Directory.Builds.Props``.

Each project has specify *targets* that apply to that platform
  - Nuget.targets
    - Targets used to import nugets
  - Source.Targets
    - Targets used to import source code


## From Source

Root ``Directory.Builds.Props`` file settings
- Set ``FromSource`` to ``true``
- Set ``XamarinFormsSource`` to point to location on your drive of Xamarin Forms source files
- Clean obj/bin and reset VS
  
Example:
```
<PropertyGroup>
    <FromSource>true</FromSource>
    <XamarinFormsSourceDir>..\Xamarin.Forms</XamarinFormsSourceDir>
    <XamarinFormsVersion>4.6.0.494-pre2</XamarinFormsVersion>  
</PropertyGroup>
```
   
## From NuGet

Root ``Directory.Builds.Props`` file settings
- Set ``FromSource`` to ``false``
- Set ``XamarinFormsVersion`` version of Xamarin.Forms Nuget you want to use
- Clean obj/bin and reset VS

Example:
```
<PropertyGroup>
    <FromSource>false</FromSource>
    <XamarinFormsSourceDir>..\Xamarin.Forms</XamarinFormsSourceDir>
    <XamarinFormsVersion>5.0.0.2083</XamarinFormsVersion>  
</PropertyGroup>
```

## Updating the submodule
After you have pulled down the submodule it's good to make sure the submodule is using the latest source code
or whatever branch you are wanting to test against

```bash
cd Xamarin.Forms
git checkout 4.5.0
```
