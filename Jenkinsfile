#!/usr/bin/env groovy

//note: this script assumes that it will be invoked from another script after that script has defined the necessary parameters

//These are: utfPath, vipbPath, lvVersion

def lvBuild(path, target_name, spec_name, lv_version) {
		echo "Build the build spec: ${spec_name} under target ${target_name} in project at ${path}"
        bat "labview-cli --kill --lv-ver ${lv_version} \"L:\\lv-build.vi\" -- \"${path}\" \"${target_name}\" \"${spec_name}\" \"build_temp\" \"${WORKSPACE}\""
}

def Mutate(veristand_version, teststand_version, step_types_version, lv_version) {
		echo "Mutate all the project files."
		bat "labview-cli --kill --lv-ver ${lv_version} \"${WORKSPACE}\\Source\\LabVIEW Code\\Version Mutation\\Mutate.vi\" -- \"${veristand_version}\" \"${teststand_version}\" \"${step_types_version}\" \"${WORKSPACE}\""
}

node{
	stage("SCM_Checkout"){
        checkout([$class: 'GitSCM', branches: [[name: '*/build_dev']], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'CleanBeforeCheckout']], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '1f3dd241-f32c-451a-b1a6-a01a3e3dd6c2', url: 'http://de-mun-repo1.ni.corp.natinst.com:5000/Real-Time-Test/Utilities-and-Tools/VeriStand-Custom-Steps-For-TestStand']]])
    }
	
	
	
	stage("Version_Mutation"){
		 Mutate(2014, 2014, "0.0.0.0", 2014)
	}
	stage("Build_PPLs"){
		lvBuild("Source\\LabVIEW Code\\Misc\\MiscHelperVIs.lvproj","My Computer","MiscHelperVIs Packed Project Library",2014)
		lvBuild("Source\\LabVIEW Code\\RT Sequence\\RTSequenceVIs.lvproj","My Computer","RTSequenceVIs Packed Project Library",2014)
		lvBuild("Source\\LabVIEW Code\\Set Channels\\Set Channels.lvproj","My Computer","Set Channels Packed Project Library",2014)
		lvBuild("Source\\LabVIEW Code\\TS VS Logger\\TS VS Logger.lvproj","My Computer","Logging Packed Project Library",2014)
	}
}
	

