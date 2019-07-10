using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.InfractionGroupDAL
{
class DALInfractionGroup_T: DataLayerBase
{

public DALInfractionGroup_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Output;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);

SqlParameter InfractionGroup_nvc =new SqlParameter();
InfractionGroup_nvc.ParameterName = "@InfractionGroup_nvc";
InfractionGroup_nvc.SqlDbType = SqlDbType.NVarChar;
InfractionGroup_nvc.Direction = ParameterDirection.Input;
InfractionGroup_nvc.IsNullable = false;
InfractionGroup_nvc.Value = businessObject.InfractionGroup_nvc;
this.Command.Parameters.Add(InfractionGroup_nvc);

SqlParameter Active_bit =new SqlParameter();
Active_bit.ParameterName = "@Active_bit";
Active_bit.SqlDbType = SqlDbType.Bit;
Active_bit.Direction = ParameterDirection.Input;
Active_bit.IsNullable = false;
Active_bit.Value = businessObject.Active_bit;
this.Command.Parameters.Add(Active_bit);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.InfractionGroupID_int = (Int32?)(this.Command.Parameters["@InfractionGroupID_int"].Value);

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void Update(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T businessObject,HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroup_nvc =new SqlParameter();
InfractionGroup_nvc.ParameterName = "@InfractionGroup_nvc";
InfractionGroup_nvc.SqlDbType = SqlDbType.NVarChar;
InfractionGroup_nvc.Direction = ParameterDirection.Input;
InfractionGroup_nvc.IsNullable = false;
InfractionGroup_nvc.Value = businessObject.InfractionGroup_nvc;
this.Command.Parameters.Add(InfractionGroup_nvc);

SqlParameter Active_bit =new SqlParameter();
Active_bit.ParameterName = "@Active_bit";
Active_bit.SqlDbType = SqlDbType.Bit;
Active_bit.Direction = ParameterDirection.Input;
Active_bit.IsNullable = false;
Active_bit.Value = businessObject.Active_bit;
this.Command.Parameters.Add(Active_bit);


SqlParameter pk_InfractionGroupID_int =new SqlParameter();
pk_InfractionGroupID_int.ParameterName = "@pk_InfractionGroupID_int";
pk_InfractionGroupID_int.SqlDbType = SqlDbType.Int;
pk_InfractionGroupID_int.Direction = ParameterDirection.Input;
pk_InfractionGroupID_int.IsNullable = false;
pk_InfractionGroupID_int.Value = businessObjectKey.InfractionGroupID_int;
this.Command.Parameters.Add(pk_InfractionGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> Result  =new  List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset,String srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T SelectByPrimaryKey(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObjectKey.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T businessObject=new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T();
if(dataReader.Read()) {
PopulateBusinessObjectFromReader(businessObject, dataReader);
}else{
businessObject = null;
}

if(dataReader.IsClosed == false) {
dataReader.Close();
}


if(ControlConnection) {
this.Commit();
}
return businessObject;}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObjectKey.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObjectKey.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObjectKey.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);



if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}





public List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> Result = new List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName ,Object  value  , ref System.Data.DataSet dataset  ,String  srcTable  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref System.Data.DataSet dataset  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public List<HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> Result= new List<HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataSet dataset,String srcTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  ,ref System.Data.DataSet dataset ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataTable dataTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void Delete(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObjectKey.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);


if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void DeleteByField(String fieldName,Object value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionGroup_T_DeleteByField]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
this.Command.Parameters.Add(new SqlParameter("@Value", value));

if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void PopulateBusinessObjectFromReader(  HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T businessObject,IDataReader dataReader){
businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString()));
businessObject.InfractionGroup_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString()));
businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.Active_bit.ToString()));
}

public List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T> list=new List< HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T>();
while (dataReader.Read()){
HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T businessObject =new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 