using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V271.Segment;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V271.Group
{
///<summary>
///Represents the RSP_K31_ENCODING Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: RXE (Pharmacy/Treatment Encoded Order) </li>
///<li>1: NTE (Notes and Comments) optional repeating</li>
///<li>2: RSP_K31_TIMING_ENCODED (a Group object) repeating</li>
///<li>3: RXR (Pharmacy/Treatment Route) repeating</li>
///<li>4: RXC (Pharmacy/Treatment Component Order) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class RSP_K31_ENCODING : AbstractGroup {

	///<summary> 
	/// Creates a new RSP_K31_ENCODING Group.
	///</summary>
	public RSP_K31_ENCODING(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXE), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(RSP_K31_TIMING_ENCODED), true, true);
	      this.add(typeof(RXR), true, true);
	      this.add(typeof(RXC), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RSP_K31_ENCODING - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary
	///</summary>
	public RXE RXE { 
get{
	   RXE ret = null;
	   try {
	      ret = (RXE)this.GetStructure("RXE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of RSP_K31_TIMING_ENCODED (a Group object) - creates it if necessary
	///</summary>
	public RSP_K31_TIMING_ENCODED GetTIMING_ENCODED() {
	   RSP_K31_TIMING_ENCODED ret = null;
	   try {
	      ret = (RSP_K31_TIMING_ENCODED)this.GetStructure("TIMING_ENCODED");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RSP_K31_TIMING_ENCODED
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RSP_K31_TIMING_ENCODED GetTIMING_ENCODED(int rep) { 
	   return (RSP_K31_TIMING_ENCODED)this.GetStructure("TIMING_ENCODED", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RSP_K31_TIMING_ENCODED 
	 */ 
	public int TIMING_ENCODEDRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TIMING_ENCODED").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RSP_K31_TIMING_ENCODED results 
	 */ 
	public IEnumerable<RSP_K31_TIMING_ENCODED> TIMING_ENCODEDs 
	{ 
		get
		{
			for (int rep = 0; rep < TIMING_ENCODEDRepetitionsUsed; rep++)
			{
				yield return (RSP_K31_TIMING_ENCODED)this.GetStructure("TIMING_ENCODED", rep);
			}
		}
	}

	///<summary>
	///Adds a new RSP_K31_TIMING_ENCODED
	///</summary>
	public RSP_K31_TIMING_ENCODED AddTIMING_ENCODED()
	{
		return this.AddStructure("TIMING_ENCODED") as RSP_K31_TIMING_ENCODED;
	}

	///<summary>
	///Removes the given RSP_K31_TIMING_ENCODED
	///</summary>
	public void RemoveTIMING_ENCODED(RSP_K31_TIMING_ENCODED toRemove)
	{
		this.RemoveStructure("TIMING_ENCODED", toRemove);
	}

	///<summary>
	///Removes the RSP_K31_TIMING_ENCODED at the given index
	///</summary>
	public void RemoveTIMING_ENCODEDAt(int index)
	{
		this.RemoveRepetition("TIMING_ENCODED", index);
	}

	///<summary>
	/// Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	///</summary>
	public RXR GetRXR() {
	   RXR ret = null;
	   try {
	      ret = (RXR)this.GetStructure("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXR
	/// * (Pharmacy/Treatment Route) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXR GetRXR(int rep) { 
	   return (RXR)this.GetStructure("RXR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXR 
	 */ 
	public int RXRRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RXR results 
	 */ 
	public IEnumerable<RXR> RXRs 
	{ 
		get
		{
			for (int rep = 0; rep < RXRRepetitionsUsed; rep++)
			{
				yield return (RXR)this.GetStructure("RXR", rep);
			}
		}
	}

	///<summary>
	///Adds a new RXR
	///</summary>
	public RXR AddRXR()
	{
		return this.AddStructure("RXR") as RXR;
	}

	///<summary>
	///Removes the given RXR
	///</summary>
	public void RemoveRXR(RXR toRemove)
	{
		this.RemoveStructure("RXR", toRemove);
	}

	///<summary>
	///Removes the RXR at the given index
	///</summary>
	public void RemoveRXRAt(int index)
	{
		this.RemoveRepetition("RXR", index);
	}

	///<summary>
	/// Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary
	///</summary>
	public RXC GetRXC() {
	   RXC ret = null;
	   try {
	      ret = (RXC)this.GetStructure("RXC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RXC
	/// * (Pharmacy/Treatment Component Order) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RXC GetRXC(int rep) { 
	   return (RXC)this.GetStructure("RXC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXC 
	 */ 
	public int RXCRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RXC").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RXC results 
	 */ 
	public IEnumerable<RXC> RXCs 
	{ 
		get
		{
			for (int rep = 0; rep < RXCRepetitionsUsed; rep++)
			{
				yield return (RXC)this.GetStructure("RXC", rep);
			}
		}
	}

	///<summary>
	///Adds a new RXC
	///</summary>
	public RXC AddRXC()
	{
		return this.AddStructure("RXC") as RXC;
	}

	///<summary>
	///Removes the given RXC
	///</summary>
	public void RemoveRXC(RXC toRemove)
	{
		this.RemoveStructure("RXC", toRemove);
	}

	///<summary>
	///Removes the RXC at the given index
	///</summary>
	public void RemoveRXCAt(int index)
	{
		this.RemoveRepetition("RXC", index);
	}

}
}
