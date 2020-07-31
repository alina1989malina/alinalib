
# react-native-alinalib

## Getting started

`$ npm install react-native-alinalib --save`

### Mostly automatic installation

`$ react-native link react-native-alinalib`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-alinalib` and add `RNAlinalib.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAlinalib.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.mylibs.RNAlinalibPackage;` to the imports at the top of the file
  - Add `new RNAlinalibPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-alinalib'
  	project(':react-native-alinalib').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-alinalib/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-alinalib')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAlinalib.sln` in `node_modules/react-native-alinalib/windows/RNAlinalib.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Alinalib.RNAlinalib;` to the usings at the top of the file
  - Add `new RNAlinalibPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAlinalib from 'react-native-alinalib';

// TODO: What to do with the module?
RNAlinalib;
```
  